// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 04-06-2020 Created : 04-06-2020 Created : 04-06-2020 Created :
// Created : 04-06-2020 Created : 04-06-2020 Created : 04-06-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 04-07-2020 Last Modified On : 07-04-2020 Last
// Last Modified On : 07-13-2020 ***********************************************************************
// <copyright file="Navigator.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using EliteMMO.API;
using PathFinder.Characters;
using PathFinder.Common;
using System;

namespace PathFinder.Tasks.Nav.States
{
    /// <summary>
    /// Class Navigator. Implements the <see cref="PathFinder.Tasks.Nav.States.NavState"/>
    /// </summary>
    /// <seealso cref="PathFinder.Tasks.Nav.States.NavState"/>
    internal class Navigator : NavState
    {
        /// <summary>
        /// The priority
        /// </summary>
        private int _priority;

        /// <summary>
        /// Initializes a new instance of the <see cref="Navigator"/> class.
        /// </summary>
        /// <param name="Character">The character.</param>
        /// <param name="options">The options.</param>
        /// <param name="Taskstate">The taskstate.</param>
        public Navigator(Character Character, Options options, Taskstate Taskstate)
            : base(Character, options, Taskstate)
        {
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
        public override bool NeedToRun
        {
            get
            {
                if (Character.Navi.DistanceTo(Character.Tasks.NavTask.Options.Posi) > 3)
                {
                    Character.FFxiNAV.Waypoints.Clear();
                    Character.Tasks.NavTask.Options.KeepMovingStartPosi.X = Character.Api.Player.X;
                    Character.Tasks.NavTask.Options.KeepMovingStartPosi.Y = Character.Api.Player.Y;
                    Character.Tasks.NavTask.Options.KeepMovingStartPosi.Z = Character.Api.Player.Z;
                    Character.FFxiNAV.FindPathToPosi(Character.Tasks.NavTask.Options.KeepMovingStartPosi, Character.Tasks.NavTask.Options.Posi, false);
                }
                if (Character.Navi.DistanceTo(Character.Tasks.NavTask.Options.Posi) < 2)
                {
                    Log.AddDebugText(TC.rtbDebug, string.Format("Nothing to do lets exit"));
                    Exit();
                }
                if (Character.FFxiNAV.PathCount() > 0)
                {
                    Character.Logger.AddDebugText(Character.Tc.rtbDebug, string.Format(@"Path found, wp count  ={0}", Character.FFxiNAV.PathCount().ToString()));

                    Character.FFxiNAV.GetWaypoints();
                }
                return Enabled
                           && !Character.Busy
                           && Character.Status == EntityStatus.Idle
                           && Character.FFxiNAV.Waypoints.Count > 0
                           && Character.Navi.DistanceTo(Character.Tasks.NavTask.Options.Posi) > 3
                           && !Character.Navi.Destination(Character.Tasks.NavTask.Options.Posi)
                           && !Character.Tasks.NavTask.Options.StopRunning;
            }
        }

        /// <summary>
        /// Priority of the state, higher = higher ( between int.MinValue and int.MaxValue)
        /// </summary>
        /// <value>The priority.</value>
        public override int Priority
        {
            get => _priority;
            set => _priority = int.MaxValue - value;
        }

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
        }

        /// <summary>
        /// The old
        /// </summary>
        private string Old;

        /// <summary>
        /// The new
        /// </summary>
        private string New;

        /// <summary>
        /// Main state loop, called every pulse, Logic goes here.
        /// </summary>
        public override void Update()
        {
            try
            {
                if (Character.FFxiNAV.Waypoints.Count > 0)
                {
                    for (var i = 0; i < Character.FFxiNAV.Waypoints.Count;)
                    {
                        position_t Point = new position_t { X = Character.FFxiNAV.Waypoints[i].X, Y = Character.FFxiNAV.Waypoints[i].Y, Z = Character.FFxiNAV.Waypoints[i].Z };
                        var Distance = Character.Navi.DistanceTo(Point);
                        var Destination = Character.Navi.Destination(Character.Tasks.NavTask.Options.Posi);
                        if (Distance > 1 && !Destination && !Character.Tasks.NavTask.Options.StopRunning)
                        {
                            Character.Navi.GoTo(Point.X, Point.Z);
                            New = string.Format(@"Pathing to x {0}, z {1}",
                                Point.X.ToString(), Point.Z.ToString());
                            if (Old != New)
                            {
                                Old = string.Format(@"Pathing to x {0}, z {1}",
                                 Point.X.ToString(), Point.Z.ToString());
                                var PlayerPosi = new position_t { X = Character.Api.Player.X, Y = Character.Api.Player.Y, Z = Character.Api.Player.Z, Moving = 0, Rotation = 0 };
                             
                                Character.Logger.AddDebugText(Character.Tc.rtbDebug, string.Format(@"Pathing to x {0}, z {1}, Distance {2}y, Can We see next Point? = {3}",
                                Point.X.ToString(), Point.Z.ToString(), Distance.ToString(), Character.FFxiNAV.CanWeSeeDestination(PlayerPosi, Point)));
                            }
                        }
                        var PlayerPos = new position_t { X = Character.Api.Player.X, Y = Character.Api.Player.Y, Z = Character.Api.Player.Z, Moving = 0, Rotation = 0 };
                        bool test = Character.FFxiNAV.CanWeSeeDestination(PlayerPos, Point);
                        double WallDistance = Character.FFxiNAV.DistanceToWall(Point);
                        if (Distance < 1 && Character.FFxiNAV.CanWeSeeDestination(PlayerPos, Point))
                        {
                            Character.Logger.AddDebugText(Character.Tc.rtbDebug, string.Format(@"Here..Can we see next point  = {0}, Point Distance to Mesh Edge {1}", test.ToString(), WallDistance.ToString()));

                            Character.Api.AutoFollow.IsAutoFollowing = false;
                            i++;
                        }
                    }
                }
                else
                    Character.FFxiNAV.Waypoints.Clear();
                Character.Api.AutoFollow.IsAutoFollowing = false;
                Exit();
            }
            catch (Exception ex)
            {
                Log.AddDebugText(TC.rtbDebug, (string.Format(@"{0} , {1}", ex.Message, this)));
            }
        }
    }
}