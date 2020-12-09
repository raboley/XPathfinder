// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created :
// Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 04-02-2020 Last Modified On : 04-12-2020 Last
// Last Modified On : 07-13-2020 ***********************************************************************
// <copyright file="Navigation.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using PathFinder.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace PathFinder.Characters
{
    /// <summary>
    /// Class Navigation.
    /// </summary>
    public class Navigation
    {
        /// <summary>
        /// The random
        /// </summary>
        public static Random rnd = new Random();

        /// <summary>
        /// The offset
        /// </summary>
        public int offset = 2000;

        /// <summary>
        /// The pull distance
        /// </summary>
        public int PullDistance = 10;

        /// <summary>
        /// The search distance
        /// </summary>
        public int SearchDistance = 50;

        /// <summary>
        /// Gets or sets the waypoints.
        /// </summary>
        /// <value>The waypoints.</value>
        public List<position_t> Waypoints { get; set; }

        /// <summary>
        /// The too close distance
        /// </summary>
        public const double TooCloseDistance = 1.5;

        /// <summary>
        /// Gets the member position.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Position.</returns>
        public Position GetMemberPosition(int id)
        {
            Position p = new Position { X = Character.Api.Entity.GetEntity(id).X, Y = Character.Api.Entity.GetEntity(id).Y, Z = Character.Api.Entity.GetEntity(id).Z, H = Character.Api.Entity.GetEntity(id).H };

            return p;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Navigation"/> class.
        /// </summary>
        /// <param name="chars">The chars.</param>
        public Navigation(Character chars)
        {
            Character = chars;
            Reset();
            Waypoints = new List<position_t>();
        }

        /// <summary>
        /// Gets or sets the character.
        /// </summary>
        /// <value>The character.</value>
        public Character Character { get; set; }

        /// <summary>
        /// Gets or sets the distance tolerance.
        /// </summary>
        /// <value>The distance tolerance.</value>
        public double DistanceTolerance { get; set; } = 3;

        /// <summary>
        /// Gets or sets the failed to path.
        /// </summary>
        /// <value>The failed to path.</value>
        public int FailedToPath { get; set; }

        /// <summary>
        /// Gets or sets the goto delay.
        /// </summary>
        /// <value>The goto delay.</value>
        public int GotoDelay { get; set; }

        /// <summary>
        /// Gets or sets the stay running amount.
        /// </summary>
        /// <value>The stay running amount.</value>
        public float StayRunningAmount { get; set; }

        /// <summary>
        /// Distances to.
        /// </summary>
        /// <param name="mobid">The mobid.</param>
        /// <returns>System.Double.</returns>
        public double DistanceTo(int mobid)
        {
            var start = new position_t { X = Character.Api.Player.X, Z = Character.Api.Player.Z };
            var dest = new position_t { X = Character.Api.Entity.GetEntity(mobid).X, Z = Character.Api.Entity.GetEntity(mobid).Z };
            return Math.Sqrt(Math.Pow(start.X - dest.X, 2) + Math.Pow(start.Z - dest.Z, 2));
        }

        /// <summary>
        /// Distancetoes the waypoint.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <returns>System.Double.</returns>
        public double DistancetoWaypoint(position_t start, position_t end)
        {
            return Math.Sqrt(Math.Pow(start.X - end.X, 2) + Math.Pow(start.Z - end.Z, 2));
        }

        /// <summary>
        /// Faces the heading.
        /// </summary>
        /// <param name="position">The position.</param>
        public void FaceHeading(position_t position)
        {
            var player = Character.Api.Entity.GetLocalPlayer();
            var Playerpos = new position_t { X = Character.Api.Player.X, Y = Character.Api.Player.Y, Z = Character.Api.Player.Z, Moving = 0, Rotation = (sbyte)Character.Api.Player.H };
            var angle = (byte)(Math.Atan((position.Z - player.Z) / (position.X - player.X)) * -(128.0f / Math.PI));
            if (player.X > position.X) angle += 128;
            var radian = (float)angle / 255 * 2 * Math.PI;
            Character.Api.Entity.SetEntityHPosition(Character.Api.Entity.LocalPlayerIndex, (float)radian);
            // Character.Logger.AddDebugText(Character.Tc.rtbDebug, string.Format(@"radian {0}
            // Rotation {1}", radian.ToString(), Character.FFxiNAV.Getrotation(Playerpos, position).ToString()));
        }

        /// <summary>
        /// Destis the specified end.
        /// </summary>
        /// <param name="End">The end.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Destination(position_t End)
        {
            if (Character.Api.Player.X == End.X + -3 && Character.Api.Player.Z == End.Z + -3)
            {
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Gets the waypoint closest to.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="z">The z.</param>
        /// <returns>position_t.</returns>
        public position_t GetWaypointClosestTo(float x, float z)
        {
            position_t ClosestWP = new position_t();
            double ClosestDistance = 9999;
            foreach (position_t wp in Waypoints)
            {
                position_t start = new position_t { X = x, Z = z };
                position_t end = new position_t { X = wp.X, Z = wp.Z };
                if (DistancetoWaypoint(start, end) < ClosestDistance)
                {
                    ClosestWP = wp;
                    ClosestDistance = DistancetoWaypoint(start, end);
                }
            }
            return ClosestWP;
        }

        /// <summary>
        /// Goes to.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="z">The z.</param>
        public void GoTo(float x, float z)
        {
            var position = new position_t { X = x, Z = z };
            if (!(DistanceTo(position) > 1)) return;
            MoveForwardTowardsPosition(position, true);
        }

        /// <summary>
        /// Gotoes the NPC.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        public void GotoNPC(int ID)
        {
            var entity = Character.Api.Entity.GetEntity(ID);
            var position = new position_t { X = entity.X, Y = entity.Y, Z = entity.Z };

            Reset();
            // FaceHeading(position);
            MoveForwardTowardsPosition(position, true);
        }

        /// <summary>
        /// Loads the waypoints.
        /// </summary>
        public void LoadWaypoints()
        {
            try
            {
            }
            catch (Exception ex)
            {
                Character.Logger.LogFile(ex.Message, "Nav");
            }
        }

        /// <summary>
        /// Clears the waypoints and grid.
        /// </summary>
        public void ClearWaypointsAndGrid()
        {
            Waypoints.Clear();
        }

        /// <summary>
        /// Resets this instance.
        /// </summary>
        public void Reset()
        {
            Character.Api.AutoFollow.IsAutoFollowing = false;
            Character.Api.ThirdParty.KeyUp(EliteMMO.API.Keys.NUMPAD8);
            Character.Api.ThirdParty.KeyUp(EliteMMO.API.Keys.NUMPAD2);
            Character.Api.ThirdParty.KeyUp(EliteMMO.API.Keys.NUMPAD6);
            Character.Api.ThirdParty.KeyUp(EliteMMO.API.Keys.NUMPAD4);
        }

        /// <summary>
        /// Sets the view mode.
        /// </summary>
        /// <param name="viewMode">The view mode.</param>
        public void SetViewMode(ViewMode viewMode)
        {
            if ((ViewMode)Character.Api.Player.ViewMode != viewMode)
            {
                Character.Api.Player.ViewMode = (int)viewMode;
            }
        }

        /// <summary>
        /// Avoids the obstacles.
        /// </summary>
        public void AvoidObstacles()
        {
            if (IsStuck())
            {
                if (Character.IsEngaged())
                    WiggleCharacter(attempts: 5);
            }
        }

        /// <summary>
        /// Distances to.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns>System.Double.</returns>
        public double DistanceTo(position_t position)
        {
            var player = Character.Api.Entity.GetLocalPlayer();

            return Math.Sqrt(Math.Pow(player.X - position.X, 2) + Math.Pow(player.Z - position.Z, 2));
        }

        /// <summary>
        /// Determines whether this instance is stuck.
        /// </summary>
        /// <returns><c>true</c> if this instance is stuck; otherwise, <c>false</c>.</returns>
        public bool IsStuck()
        {
            var firstX = Character.Api.Player.X;
            var firstZ = Character.Api.Player.Z;
            Thread.Sleep(TimeSpan.FromMilliseconds(500));
            var dchange = Math.Pow(firstX - Character.Api.Player.X, 2) + Math.Pow(firstZ - Character.Api.Player.Z, 2);
            return Math.Abs(dchange) < 1;
        }

        /// <summary>
        /// Keeps the one yalm back.
        /// </summary>
        /// <param name="position">The position.</param>
        public void KeepOneYalmBack(position_t position)
        {
            if (DistanceTo(position) > TooCloseDistance) return;

            DateTime duration = DateTime.Now.AddSeconds(5);
            Character.Api.ThirdParty.KeyDown(EliteMMO.API.Keys.NUMPAD2);

            while (DistanceTo(position) <= TooCloseDistance && DateTime.Now < duration)
            {
                SetViewMode(ViewMode.FirstPerson);
                FaceHeading(position);
                Thread.Sleep(30);
            }

            Character.Api.ThirdParty.KeyUp(EliteMMO.API.Keys.NUMPAD2);
        }

        /// <summary>
        /// Keeps the running with keyboard.
        /// </summary>
        public void KeepRunningWithKeyboard()
        {
            Character.Api.ThirdParty.KeyDown(EliteMMO.API.Keys.NUMPAD8);
        }

        /// <summary>
        /// Moves the forward towards position.
        /// </summary>
        /// <param name="TargetPosition">The target position.</param>
        /// <param name="useObjectAvoidance">if set to <c>true</c> [use object avoidance].</param>
        public void MoveForwardTowardsPosition(
                                position_t TargetPosition, bool useObjectAvoidance)
        {
            if (DistanceTo(TargetPosition) > 1)
            {
                var player = Character.Api.Player; var i = DistanceTo(TargetPosition);

                float normalized = (float)i;
                float goToX = 0;
                float goToZ = 0;
                float goToY = 0;
                if (player.X != 0 || player.Z != 0 || TargetPosition.X != 0 || TargetPosition.Z != 0)
                {
                    goToX = (TargetPosition.X - player.X) / normalized;
                    goToZ = (TargetPosition.Z - player.Z) / normalized;
                    goToY = (TargetPosition.Y - player.Y) / normalized;
                }
                // FaceHeading(TargetPosition);
                Character.Api.AutoFollow.SetAutoFollowCoords(goToX, 0, goToZ);
                Character.Api.AutoFollow.IsAutoFollowing = true;

            }
        }

        /// <summary>
        /// Wiggles the character.
        /// </summary>
        /// <param name="attempts">The attempts.</param>
        public void WiggleCharacter(int attempts)
        {
            int count = 0;
            float dir = -45;
            while (IsStuck() && attempts-- > 0)
            {
                Character.Api.Entity.GetLocalPlayer().H = Character.Api.Player.H + (float)(Math.PI / 180 * dir);
                Character.Api.ThirdParty.KeyDown(EliteMMO.API.Keys.NUMPAD8);
                Thread.Sleep(TimeSpan.FromSeconds(2));
                Character.Api.ThirdParty.KeyUp(EliteMMO.API.Keys.NUMPAD8);
                count++;
                if (count == 4)
                {
                    dir = (Math.Abs(dir - -45) < .001 ? 45 : -45);
                    count = 0;
                }
            }
            Character.Api.ThirdParty.KeyUp(EliteMMO.API.Keys.NUMPAD8);
        }

        /// <summary>
        /// Gets the player position h in degrees.
        /// </summary>
        /// <returns>System.Double.</returns>
        public double GetPlayerPosHInDegrees()
        {
            return PosHToDegrees(Character.Api.Player.H);
        }

        /// <summary>
        /// Positions the h to degrees.
        /// </summary>
        /// <param name="PosH">The position h.</param>
        /// <returns>System.Double.</returns>
        public double PosHToDegrees(float PosH)
        {
            // Formula: d = (((PosH * 180) / Math.PI) + 90) % 360;
            double d;

            // Convert from Degrees to Radians
            d = ((PosH * 180.0) / Math.PI);

            // Translate to Degree(Start) from FFXIRadians(Start) (Add 90deg) and Normalize
            return MathMod((d + (double)90.0), (double)360.0000);
        }

        /// <summary>
        /// Mathes the mod.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns>System.Double.</returns>
        public double MathMod(double a, double b)
        {
            // 4 known ways to do it here (a - (b * Math.Floor(a / b))) (a - (b * (Math.Sign(b) *
            // Math.Floor(a / Math.Abs(b))))) (Math.Abs(a * b) + a) % b ((a % b) + b) % b // <- THIS
            // ONE IS THE FASTEST!
            return ((a % b) + b) % b;
        }
    }
}