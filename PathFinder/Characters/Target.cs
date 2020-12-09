// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created :
// Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 04-04-2020 Last Modified On : 04-12-2020 Last
// Last Modified On : 07-13-2020 ***********************************************************************
// <copyright file="Target.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using EliteMMO.API;
using PathFinder.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PathFinder.Characters
{
    /// <summary>
    /// Class Target.
    /// </summary>
    public class Target
    {
        /// <summary>
        /// The distance
        /// </summary>
        public int _Distance = 50;

        /// <summary>
        /// The blocked targets
        /// </summary>
        public List<int> BlockedTargets = new List<int>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Target"/> class.
        /// </summary>
        /// <param name="Api">The API.</param>
        public Target(Character Api)
        {
            Character = Api;
            Targets = new List<string>();
        }

        /// <summary>
        /// Gets or sets the target mob identifier.
        /// </summary>
        /// <value>The target mob identifier.</value>
        public int TargetMobId { get; set; }

        /// <summary>
        /// Gets or sets the log.
        /// </summary>
        /// <value>The log.</value>
        public Log log { get; set; }

        /// <summary>
        /// Gets or sets the character.
        /// </summary>
        /// <value>The character.</value>
        public Character Character { get; set; }

        /// <summary>
        /// Gets or sets the targets.
        /// </summary>
        /// <value>The targets.</value>
        public List<string> Targets { get; set; }

        /// <summary>
        /// Gets or sets the best target.
        /// </summary>
        /// <value>The best target.</value>
        private int BestTarget { get; set; }

        /// <summary>
        /// Finds the best target.
        /// </summary>
        /// <returns>System.Int32.</returns>
        public int FindBestTarget()
        {
            if (Character.Tasks.RandomPathTask.Options.Targets.Count > 0)
            {
                var index = Enumerable.Range(0, 768)
                                 .Where(i => IsRendered(i) && IsAttackable(Character.Tasks.RandomPathTask.Options.Targets, i, Character.Tasks.RandomPathTask.Options.SearchDistance))
                                 .OrderBy(i => Character.Api.Entity.GetEntity(i).Distance)
                                 .Select(i => i).FirstOrDefault();

                return index;
            }
            else return 0;
        }

        /// <summary>
        /// Gets the NPC names.
        /// </summary>
        /// <returns>List&lt;System.String&gt;.</returns>
        public List<string> GetNpcNames()
        {
            var list = new List<string>();
            for (var i = 0; i < 768; i++)
            {
                if (!string.IsNullOrEmpty(Character.Api.Entity.GetEntity(i).Name))

                    list.Add(Character.Api.Entity.GetEntity(i).Name);
            }
            return list;
        }

        /// <summary>
        /// Gets the NPC i ds.
        /// </summary>
        /// <returns>List&lt;System.Int32&gt;.</returns>
        public List<int> GetNpcIDs()
        {
            var list = new List<int>();
            for (var i = 0; i < 768; i++)
            {
                if (!string.IsNullOrEmpty(Character.Api.Entity.GetEntity(i).Name))

                    list.Add(i);
            }
            return list;
        }

        /// <summary>
        /// Determines whether this instance has aggro.
        /// </summary>
        /// <returns><c>true</c> if this instance has aggro; otherwise, <c>false</c>.</returns>
        public bool HasAggro()
        {
            if (Character.Status != EntityStatus.Engaged)
            {
                for (var i = 0; i < 768; i++)
                {
                    if (Character.Api.Entity.GetEntity(i).Distance < 21 &&
                    Character.Api.Entity.GetEntity(i).Status == (uint)EntityStatus.Engaged &&
                    Character.Api.Entity.GetEntity(i).ClaimID == 0)
                    {
                        Character.Logger.AddDebugText(Character.Tc.rtbDebug, "Possible Aggro");
                        return true;
                    }
                    if (Character.Api.Entity.GetEntity(i).Distance < 21 &&
                  Character.Api.Entity.GetEntity(i).Status == (uint)EntityStatus.Engaged &&
                  Character.Api.Entity.GetEntity(i).ClaimID == Character.Api.Player.ServerId)
                    {
                        Character.Logger.AddDebugText(Character.Tc.rtbDebug, "Possible Aggro");
                        return true;
                    }
                    if (Character.Api.Entity.GetEntity(i).Distance < 21 &&
           Character.Api.Entity.GetEntity(i).Status == (uint)EntityStatus.Engaged &&
           Character.Api.Entity.GetEntity(i).ClaimID == Character.Api.Player.ServerID)
                    {
                        Character.Logger.AddDebugText(Character.Tc.rtbDebug, "Possible Aggro");
                        return true;
                    }
                    if (Character.Api.Entity.GetEntity(i).Distance < 21 &&
           Character.Api.Entity.GetEntity(i).Status == (uint)EntityStatus.Engaged &&
           Character.Api.Entity.GetEntity(i).ClaimID == Character.Api.Party.GetPartyMember(0).ID)
                    {
                        Character.Logger.AddDebugText(Character.Tc.rtbDebug, "Possible Aggro");
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether the specified mob index is aggro.
        /// </summary>
        /// <param name="mobIndex">Index of the mob.</param>
        /// <returns><c>true</c> if the specified mob index is aggro; otherwise, <c>false</c>.</returns>
        public bool IsAggro(int mobIndex)
        {
            return false;
        }

        /// <summary>
        /// Determines whether the specified targets is attackable.
        /// </summary>
        /// <param name="Targets">The targets.</param>
        /// <param name="mobIndex">Index of the mob.</param>
        /// <param name="distance">The distance.</param>
        /// <returns><c>true</c> if the specified targets is attackable; otherwise, <c>false</c>.</returns>
        public bool IsAttackable(ICollection<string> Targets, int mobIndex, int distance)
        {
            if (Targets.Count == 0 || Targets.Contains(Character.Api.Entity.GetEntity(mobIndex).Name, StringComparer.InvariantCultureIgnoreCase))
            {
                return

                    Test(mobIndex)
                    &&
                       Character.Api.Entity.GetEntity(mobIndex).HealthPercent == 100
                       && (Character.Api.Entity.GetEntity(mobIndex).HealthPercent < 100 || IsPartyClaim(mobIndex))
                       && IsAggro(mobIndex)
                       && !IsClaimedBySomeoneElse(mobIndex)
                       && Character.Api.Entity.GetEntity(mobIndex).Status != (uint)EntityStatus.Dead || Character.Api.Entity.GetEntity(mobIndex).Status != (uint)EntityStatus.DeadEngaged
                       && Character.Api.Entity.GetEntity(mobIndex).Distance < Character.Tasks.RandomPathTask.Options.SearchDistance
                       && Character.Api.Entity.GetEntity(mobIndex).HealthPercent != 0;
            }

            return false;
        }

        /// <summary>
        /// Tests the specified mob index.
        /// </summary>
        /// <param name="mobIndex">Index of the mob.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Test(int mobIndex)
        {
            var moby = Character.Api.Entity.GetEntity(mobIndex).Y;
            var Ydif = (Math.Abs(moby - Character.Api.Player.Y));
            if (Ydif < 3)
            {
                return true;
            }
            if (Ydif > 3)
            {
                return false;
            }
            else return false;
        }

        /// <summary>
        /// Determines whether [is claimed by someone else] [the specified mob index].
        /// </summary>
        /// <param name="mobIndex">Index of the mob.</param>
        /// <returns>
        /// <c>true</c> if [is claimed by someone else] [the specified mob index]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsClaimedBySomeoneElse(int mobIndex)
        {
            var mob = Character.Api.Entity.GetEntity(mobIndex);
            if (mob.ClaimID != 0 && !IsPartyClaim(mobIndex))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Determines whether [is party claim] [the specified mob index].
        /// </summary>
        /// <param name="mobIndex">Index of the mob.</param>
        /// <returns><c>true</c> if [is party claim] [the specified mob index]; otherwise, <c>false</c>.</returns>
        public bool IsPartyClaim(int mobIndex)
        {
            var mob = Character.Api.Entity.GetEntity(mobIndex);
            for (byte i = 0; i < Character.Api.Party.GetPartyMembers().Count; i++)
            {
                if (Convert.ToBoolean(Character.Api.Party.GetPartyMember(i).Active) && mob.ClaimID == Character.Api.Party.GetPartyMember(i).ID && mob.HealthPercent > 0)
                {
                    return true;
                }
            }
            return false;
        }

        // public bool IsPartyClaim(int mobIndex) { for (byte i = 0; i < 16; i++) { var ClaimedID =
        // Character.Api.Entity.GetEntity(mobIndex).ClaimID; var MemberID =
        // Character.Api.Party.GetPartyMember(i).ID; { if (ClaimedID == MemberID &&
        // Character.Api.Entity.GetEntity(mobIndex).HealthPercent > 0) { return true; } }

        // var playerid = Character.Api.Player.ServerID; { if (ClaimedID == playerid) { return true;
        // } } } return false; }

        /// <summary>
        /// Determines whether the specified identifier is rendered.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if the specified identifier is rendered; otherwise, <c>false</c>.</returns>
        public bool IsRendered(int id)
        {
            var i = Character.Api.Entity.GetEntity(id).Render0000;
            var i2 = Character.Api.Entity.GetEntity(id).Render0000 & 0x200;
            if (i2 == 512)
            {
                return true;
            }
            else

                return false;
        }

        /// <summary>
        /// Targets the NPC.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool TargetNpc(int id)
        {
            var Target = Character.Api.Target.GetTargetInfo();
            if (Target.TargetIndex != id)
            {
                Character.Api.Target.SetTarget(id);
                Character.Api.ThirdParty.SendString("/Target <t>");
                Thread.Sleep(10);
                Character.Api.ThirdParty.SendString("/lockon <t>");
                return true;
            }
            else return false;
        }
    }
}