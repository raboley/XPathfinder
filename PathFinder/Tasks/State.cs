// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 04-03-2020 Created : 04-03-2020 Created : 04-03-2020 Created :
// Created : 04-03-2020 Created : 04-03-2020 Created : 04-03-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 04-03-2020 Last Modified On : 04-12-2020 Last
// Last Modified On : 07-13-2020 ***********************************************************************
// <copyright file="State.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using PathFinder.Characters;
using System;
using System.Collections.Generic;
using System.Threading;

namespace PathFinder.Tasks
{
    /// <summary>
    /// Class State. Implements the <see cref="PathFinder.Tasks.TaskBase"/> Implements the <see
    /// cref="System.IComparable{PathFinder.Tasks.State}"/> Implements the <see cref="System.Collections.Generic.IComparer{PathFinder.Tasks.State}"/>
    /// </summary>
    /// <seealso cref="PathFinder.Tasks.TaskBase"/>
    /// <seealso cref="System.IComparable{PathFinder.Tasks.State}"/>
    /// <seealso cref="System.Collections.Generic.IComparer{PathFinder.Tasks.State}"/>
    public abstract class State : TaskBase, IComparable<State>, IComparer<State>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="State"/> class.
        /// </summary>
        /// <param name="Character">The character.</param>
        protected State(Character Character)
            : base(Character)
        {
        }

        /// <summary>
        /// Is this state enabled?
        /// </summary>
        /// <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
        public bool Enabled { get; set; }

        /// <summary>
        /// Determines the frequency (Frame count) between each attempt to check, and run, this
        /// state. Default 0 is to run it every frame
        /// </summary>
        /// <value>The frequency.</value>
        public virtual int Frequency => 0;

        /// <summary>
        /// Is this state running?
        /// </summary>
        /// <value><c>true</c> if this instance is running; otherwise, <c>false</c>.</value>
        public bool IsRunning { get; set; }

        /// <summary>
        /// Does this state need to run?
        /// </summary>
        /// <value><c>true</c> if [need to run]; otherwise, <c>false</c>.</value>
        public abstract bool NeedToRun { get; }

        /// <summary>
        /// Priority of the state, higher = higher ( between int.MinValue and int.MaxValue)
        /// </summary>
        /// <value>The priority.</value>
        public abstract int Priority { get; set; }

        /// <summary>
        /// Allow us to cancel our state
        /// </summary>
        /// <value>The token.</value>
        public CancellationToken Token { get; set; }

        /// <summary>
        /// Compares two objects and returns a value indicating whether one is less than, equal to,
        /// or greater than the other.
        /// </summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        /// <returns>
        /// A signed integer that indicates the relative values of <paramref name="x"/> and
        /// <paramref name="y"/>, as shown in the following table.Value Meaning Less than zero
        /// <paramref name="x"/> is less than <paramref name="y"/>.Zero <paramref name="x"/> equals
        /// <paramref name="y"/>.Greater than zero <paramref name="x"/> is greater than <paramref name="y"/>.
        /// </returns>
        public int Compare(State x, State y)
        {
            return -x.Priority.CompareTo(y.Priority);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type and returns an
        /// integer that indicates whether the current instance precedes, follows, or occurs in the
        /// same position in the sort order as the other object.
        /// </summary>
        /// <param name="other">An object to compare with this instance.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. The return
        /// value has these meanings: Value Meaning Less than zero This instance precedes <paramref
        /// name="other"/> in the sort order. Zero This instance occurs in the same position in the
        /// sort order as <paramref name="other"/>. Greater than zero This instance follows
        /// <paramref name="other"/> in the sort order.
        /// </returns>
        public int CompareTo(State other)
        {
            // We want the highest first. int, by default, chooses the lowest to be sorted at the
            // bottom of the list. We want the opposite.
            return -Priority.CompareTo(other.Priority);
        }

        /// <summary>
        /// Called when we enter this state.
        /// </summary>
        public abstract void Enter();

        /// <summary>
        /// Called when we exit this state
        /// </summary>
        public abstract void Exit();

        /// <summary>
        /// Main state loop, called every pulse, Logic goes here.
        /// </summary>
        public abstract void Update();
    }
}