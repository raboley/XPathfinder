// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 04-04-2020 Created : 04-04-2020 Created : 04-04-2020 Created :
// Created : 04-04-2020 Created : 04-04-2020 Created : 04-04-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 04-04-2020 Last Modified On : 04-12-2020 Last
// Last Modified On : 07-13-2020 ***********************************************************************
// <copyright file="NavTask.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using PathFinder.Characters;
using PathFinder.Common;
using PathFinder.Contracts;
using PathFinder.Tasks.Random.States;
using System;

namespace PathFinder.Tasks.Random
{
    /// <summary>
    /// Class RandomPathTask. Implements the <see cref="PathFinder.Tasks.TaskBase"/> Implements the
    /// <see cref="PathFinder.Contracts.ITask"/>
    /// </summary>
    /// <seealso cref="PathFinder.Tasks.TaskBase"/>
    /// <seealso cref="PathFinder.Contracts.ITask"/>
    public class RandomPathTask : TaskBase, ITask
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RandomPathTask"/> class.
        /// </summary>
        /// <param name="Character">The character.</param>
        public RandomPathTask(Character Character)
            : base(Character)
        {
            Options = XmlSerializationHelper.Deserialize<Options>(FileName) ?? new Options();
            TS = new Taskstate(Character, Options);
            TS.Stopped += Stop;
            Engine = new StateEngine();

            InitializeStateEngine();
        }

        /// <summary>
        /// Occurs when [started].
        /// </summary>
        public event EventHandler Started = delegate { };

        /// <summary>
        /// Occurs when [stopped].
        /// </summary>
        public event EventHandler Stopped = delegate { };

        /// <summary>
        /// Gets a value indicating whether this instance is busy.
        /// </summary>
        /// <value><c>true</c> if this instance is busy; otherwise, <c>false</c>.</value>
        public bool IsBusy => Engine.IsRunning;

        /// <summary>
        /// Gets or sets the options.
        /// </summary>
        /// <value>The options.</value>
        public Options Options { get; set; }

        /// <summary>
        /// Gets the engine.
        /// </summary>
        /// <value>The engine.</value>
        private StateEngine Engine { get; }

        /// <summary>
        /// Gets the ts.
        /// </summary>
        /// <value>The ts.</value>
        private Taskstate TS { get; }

        /// <summary>
        /// Saves the specified file name.
        /// </summary>
        /// <param name="FileName">Name of the file.</param>
        public void Save(string FileName)
        {
            XmlSerializationHelper.Serialize(FileName, Options);
        }

        /// <summary>
        /// Loads the settings.
        /// </summary>
        /// <param name="File">The file.</param>
        public void LoadSettings(string File)
        {
            Options = XmlSerializationHelper.Deserialize<Options>(File) ?? new Options();
        }

        /// <summary>
        /// Starts this instance.
        /// </summary>
        public override void Start()
        {
            if (Engine.IsRunning)
            {
                return;
            }
            TS.Start();
            Engine.Start(2);
            Started(this, EventArgs.Empty);
            Log.AddDebugText(TC.rtbDebug, "Started");
        }

        /// <summary>
        /// Stops the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public override void Stop(string msg = null)
        {
            // Target.Reset();
            if (!Engine.IsRunning)
            {
                return;
            }

            TS.Stop();
            Engine.Stop();
            Log.AddDebugText(TC.rtbDebug, msg);
            Stopped(this, EventArgs.Empty);

            Log.AddDebugText(TC.rtbDebug, "Stopped");
        }

        /// <summary>
        /// Initializes the state engine.
        /// </summary>
        private void InitializeStateEngine()
        {
            Engine.AddState(new Idle(Character, Options, TS) { OnDeath = true, OnPartyDisband = true });
            //Engine.AddState(new InventoryChecks(Character, Options, TS) { Priority = 1, Enabled = true });
            //Engine.AddState(new Debuff(Character, Options, TS) { Priority = 4, Enabled = true });
            //Engine.AddState(new Cures(Character, Options, TS) { Priority = 5, Enabled = true });
            //Engine.AddState(new CureOthers(Character, Options, TS) { Priority = 5, Enabled = true });
            //Engine.AddState(new DncCure(Character, Options, TS) { Priority = 5, Enabled = true });
            //Engine.AddState(new BUFFS(Character, Options, TS) { Priority = 4, Enabled = true });
            //Engine.AddState(new AcceptRaise(Character, Options, TS) { Priority = 1, });
            //Engine.AddState(new GoHome(Character, Options, TS) { Priority = 1, });
            //Engine.AddState(new HealOn(Character, Options, TS) { Priority = 1, });
            Engine.AddState(new Navigator(Character, Options, TS) { Priority = 1, });
            //Engine.AddState(new HealOff(Character, Options, TS) { Priority = 1, Enabled = true });
            //Engine.AddState(new JobAbilityKeepActive(Character, Options, TS) { Priority = 2, Enabled = true });
            //Engine.AddState(new TrackNextTarget(Character, Options, TS) { Priority = 3 });
            //Engine.AddState(new Pulling(Character, Options, TS) { Priority = 2 });
            //Engine.AddState(new LockOn(Character, Options, TS) { Priority = 2 });
            //Engine.AddState(new Engage(Character, Options, TS) { Priority = 2 });
            //Engine.AddState(new TrackWhileFighting(Character, Options, TS) { Priority = 3 });
            //Engine.AddState(new JobAbilityFightOnly(Character, Options, TS) { Priority = 1, Enabled = true });
            //Engine.AddState(new WeaponSkill(Character, Options, TS) { Priority = 3 });
            //Engine.AddState(new TrackWhileFighting(Character, Options, TS) { Priority = 3 });
        }
    }
}