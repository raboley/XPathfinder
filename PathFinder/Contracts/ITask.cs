// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 04-03-2020 Created : 04-03-2020 Created : 04-03-2020 Created :
// Created : 04-03-2020 Created : 04-03-2020 Created : 04-03-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 04-04-2020 Last Modified On : 04-12-2020 Last
// Last Modified On : 07-13-2020 ***********************************************************************
// <copyright file="ITask.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************

namespace PathFinder.Contracts
{
    /// <summary>
    /// Interface ITask
    /// </summary>
    internal interface ITask
    {
        /// <summary>
        /// Gets a value indicating whether this instance is busy.
        /// </summary>
        /// <value><c>true</c> if this instance is busy; otherwise, <c>false</c>.</value>
        bool IsBusy { get; }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        void Save();

        /// <summary>
        /// Starts this instance.
        /// </summary>
        void Start();

        /// <summary>
        /// Stops the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        void Stop(string msg = null);
    }
}