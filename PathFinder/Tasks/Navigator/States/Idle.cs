// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 04-03-2020 Created : 04-03-2020 Created : 04-03-2020 Created :
// Created : 04-03-2020 Created : 04-03-2020 Created : 04-03-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 04-04-2020 Last Modified On : 04-12-2020 Last
// Last Modified On : 07-13-2020 ***********************************************************************
// <copyright file="Idle.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using PathFinder.Characters;
using System;
using System.Threading;

namespace PathFinder.Tasks.Nav.States
{
    /// <summary>
    /// Class Idle. Implements the <see cref="PathFinder.Tasks.Nav.States.NavState"/>
    /// </summary>
    /// <seealso cref="PathFinder.Tasks.Nav.States.NavState"/>
    internal class Idle : NavState
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Idle"/> class.
        /// </summary>
        /// <param name="Character">The character.</param>
        /// <param name="options">The options.</param>
        /// <param name="Taskstate">The taskstate.</param>
        public Idle(Character Character, Options options, Taskstate Taskstate)
            : base(Character, options, Taskstate)
        {
            Priority = int.MinValue;
            Enabled = true;
        }

        /// <summary>
        /// Determines the frequency (Frame count) between each attempt to check, and run, this
        /// state. Default 0 is to run it every frame
        /// </summary>
        /// <value>The frequency.</value>
        public override int Frequency => 0;

        /// <summary>
        /// Does this state need to run?
        /// </summary>
        /// <value><c>true</c> if [need to run]; otherwise, <c>false</c>.</value>
        public override bool NeedToRun => TS.TargetMobId == 0;

        /// <summary>
        /// Gets or sets a value indicating whether [on death].
        /// </summary>
        /// <value><c>true</c> if [on death]; otherwise, <c>false</c>.</value>
        public bool OnDeath { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [on party disband].
        /// </summary>
        /// <value><c>true</c> if [on party disband]; otherwise, <c>false</c>.</value>
        public bool OnPartyDisband { get; set; }

        /// <summary>
        /// Priority of the state, higher = higher ( between int.MinValue and int.MaxValue)
        /// </summary>
        /// <value>The priority.</value>
        public sealed override int Priority { get; set; }

        /// <summary>
        /// Called when we enter this state.
        /// </summary>
        public override void Enter()
        {
            Log.AddDebugText(TC.rtbDebug, string.Format("Entering {0} State", GetType().Name));
        }

        /// <summary>
        /// Called when we exit this state
        /// </summary>
        public override void Exit()
        {
            Character.Navi.Reset();
            Log.AddDebugText(TC.rtbDebug, string.Format("Exiting {0} State", GetType().Name));
            WriteTextSafe("Start");
        }

        /// <summary>
        /// Delegate SafeCallDelegate
        /// </summary>
        /// <param name="text">The text.</param>
        private delegate void SafeCallDelegate(string text);

        /// <summary>
        /// Writes the text safe.
        /// </summary>
        /// <param name="text">The text.</param>
        private void WriteTextSafe(string text)
        {
            if (Character.Tc.RunBtn.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                Character.Tc.RunBtn.Invoke(d, new object[] { text });
            }
            else
            {
                Character.Tc.RunBtn.Text = text;
            }
        }

        /// <summary>
        /// Main state loop, called every pulse, Logic goes here.
        /// </summary>
        public override void Update()
        {
            try
            {
                if (Character.Navi.Destination(Character.Tasks.NavTask.Options.Posi))
                {
                    Character.Logger.AddDebugText(TC.rtbDebug, "We are here!!");
                    Character.FFxiNAV.Waypoints.Clear();
                    Character.Tasks.NavTask.Stop();
                    Character.Tasks.Stop();
                    Character.Navi.Reset();
                    Thread.Sleep(200);
                    Character.Navi.Reset();
                }
                if (Character.Navi.DistanceTo(Character.Tasks.NavTask.Options.Posi) > 5)
                {
                    Character.Logger.AddDebugText(TC.rtbDebug, "We are not close to destination so lets keep looking");

                    Character.Tasks.NavTask.Options.KeepMovingStartPosi.X = Character.Api.Player.X;
                    Character.Tasks.NavTask.Options.KeepMovingStartPosi.Y = Character.Api.Player.Y;
                    Character.Tasks.NavTask.Options.KeepMovingStartPosi.Z = Character.Api.Player.Z;
                    Character.FFxiNAV.FindPathToPosi(Character.Tasks.NavTask.Options.KeepMovingStartPosi, Character.Tasks.NavTask.Options.Posi, false);
                }
                else
                    Character.Tasks.NavTask.Stop();
                Character.Tasks.Stop();
                Character.FFxiNAV.Waypoints.Clear();
                Character.Navi.Reset();
                Thread.Sleep(200);
                Character.Navi.Reset();
                Exit();
            }
            catch (Exception ex)
            {
                Log.AddDebugText(TC.rtbDebug, (string.Format(@"{0} , {1}", ex.Message, this)));
            }
        }
    }
}