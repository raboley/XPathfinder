// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 04-03-2020 Created : 04-03-2020 Created : 04-03-2020 Created :
// Created : 04-03-2020 Created : 04-03-2020 Created : 04-03-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 04-04-2020 Last Modified On : 04-12-2020 Last
// Last Modified On : 07-13-2020 ***********************************************************************
// <copyright file="TaskState.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using PathFinder.Characters;
using PathFinder.Common;
using System;
using System.Timers;

namespace PathFinder.Tasks.Nav
{
    /// <summary>
    /// Class Taskstate.
    /// </summary>
    public class Taskstate
    {
        /// <summary>
        /// The timer
        /// </summary>
        private readonly Timer _timer = new Timer { Interval = 10 };

        /// <summary>
        /// Initializes a new instance of the <see cref="Taskstate"/> class.
        /// </summary>
        /// <param name="character">The character.</param>
        /// <param name="options">The options.</param>
        public Taskstate(Character character, Options options)
        {
            Character = character;
            Options = options;
            PreviousChestIndieces = new LimitedQueue<int>(3);
            _timer.Elapsed += Update;
            DominionSergeantIndex = -1;
        }

        /// <summary>
        /// Occurs when [stopped].
        /// </summary>
        public event Action<string> Stopped = delegate { };

        /// <summary>
        /// Gets or sets the index of the dominion sergeant.
        /// </summary>
        /// <value>The index of the dominion sergeant.</value>
        public int DominionSergeantIndex { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Taskstate"/> is initialized.
        /// </summary>
        /// <value><c>true</c> if initialized; otherwise, <c>false</c>.</value>
        public bool Initialized { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [move enabled].
        /// </summary>
        /// <value><c>true</c> if [move enabled]; otherwise, <c>false</c>.</value>
        public bool MoveEnabled { get; set; }

        /// <summary>
        /// Gets or sets the previous chest indieces.
        /// </summary>
        /// <value>The previous chest indieces.</value>
        public LimitedQueue<int> PreviousChestIndieces { get; set; }

        /// <summary>
        /// Gets or sets the signet NPC.
        /// </summary>
        /// <value>The signet NPC.</value>
        public string SignetNpc { get; set; }

        /// <summary>
        /// Gets or sets the index of the target chest.
        /// </summary>
        /// <value>The index of the target chest.</value>
        public int TargetChestIndex { get; set; }

        /// <summary>
        /// Gets the target mob identifier.
        /// </summary>
        /// <value>The target mob identifier.</value>
        public int TargetMobId => Character.Target.FindBestTarget();

        /// <summary>
        /// Gets or sets a value indicating whether [track chests].
        /// </summary>
        /// <value><c>true</c> if [track chests]; otherwise, <c>false</c>.</value>
        public bool TrackChests { get; set; }

        /// <summary>
        /// Gets the character.
        /// </summary>
        /// <value>The character.</value>
        private Character Character { get; }

        /// <summary>
        /// Gets the options.
        /// </summary>
        /// <value>The options.</value>
        private Options Options { get; }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public void Initialize()
        {
            Initialized = false;
            MoveEnabled = false;
        }

        /// <summary>
        /// Starts this instance.
        /// </summary>
        public void Start()
        {
            Initialize();
            _timer.Enabled = true;
        }

        /// <summary>
        /// Stops this instance.
        /// </summary>
        public void Stop()
        {
            _timer.Enabled = false;
        }

        /// <summary>
        /// Updates the specified sender.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="ElapsedEventArgs"/> instance containing the event data.</param>
        private void Update(object sender, ElapsedEventArgs e)
        {
            //TargetMobId = Character.Api == null
            //    ? Character.Target.GetClosestAttackableMobId(Options.Targets, null, distance)
            //    : Character.Status == EntityStatus.Engaged
            //        ? Character.Leader.Target.GetClosestAttackableMobId(Options.Targets, null, 15)
            //        : 0;
        }
    }
}