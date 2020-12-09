// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 04-03-2020 Created : 04-03-2020 Created : 04-03-2020 Created :
// Created : 04-03-2020 Created : 04-03-2020 Created : 04-03-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 04-04-2020 Last Modified On : 04-12-2020 Last
// Last Modified On : 07-13-2020 ***********************************************************************
// <copyright file="NavState.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using PathFinder.Characters;

namespace PathFinder.Tasks.Nav.States
{
    /// <summary>
    /// Class NavState. Implements the <see cref="PathFinder.Tasks.State"/>
    /// </summary>
    /// <seealso cref="PathFinder.Tasks.State"/>
    internal abstract class NavState : State
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NavState"/> class.
        /// </summary>
        /// <param name="Character">The character.</param>
        /// <param name="options">The options.</param>
        /// <param name="Taskstate">The taskstate.</param>
        protected NavState(Character Character, Options options, Taskstate Taskstate)
            : base(Character)
        {
            Options = options;
            TS = Taskstate;
        }

        /// <summary>
        /// Gets the options.
        /// </summary>
        /// <value>The options.</value>
        public Options Options { get; }

        /// <summary>
        /// Gets the ts.
        /// </summary>
        /// <value>The ts.</value>
        public Taskstate TS { get; }
    }
}