// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 04-03-2020 Created : 04-03-2020 Created : 04-03-2020 Created :
// Created : 04-03-2020 Created : 04-03-2020 Created : 04-03-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 04-04-2020 Last Modified On : 04-12-2020 Last
// Last Modified On : 07-13-2020 ***********************************************************************
// <copyright file="TaskBase.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using EliteMMO.API;
using PathFinder.Characters;
using PathFinder.Common;

namespace PathFinder.Tasks
{
    /// <summary>
    /// Class TaskBase.
    /// </summary>
    public class TaskBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskBase"/> class.
        /// </summary>
        /// <param name="character">The character.</param>
        public TaskBase(Character character)
        {
            Character = character;
            Api = Character.Api;
            Log = Character.Logger;
            TC = Character.Tc;
            Navi = Character.Navi;
            Target = Character.Target;
            FFxiNav = character.FFxiNAV;
        }

        /// <summary>
        /// Gets or sets the API.
        /// </summary>
        /// <value>The API.</value>
        internal EliteAPI Api { get; set; }

        /// <summary>
        /// Gets or sets the character.
        /// </summary>
        /// <value>The character.</value>
        internal Character Character { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        internal string FileName { get; set; }

        /// <summary>
        /// Gets or sets the log.
        /// </summary>
        /// <value>The log.</value>
        internal Log Log { get; set; }

        /// <summary>
        /// Gets or sets the navi.
        /// </summary>
        /// <value>The navi.</value>
        internal Navigation Navi { get; set; }

        /// <summary>
        /// Gets or sets the target.
        /// </summary>
        /// <value>The target.</value>
        internal Target Target { get; set; }

        /// <summary>
        /// Gets or sets the tc.
        /// </summary>
        /// <value>The tc.</value>
        internal ToonControl TC { get; set; }

        /// <summary>
        /// Gets or sets the f fxi nav.
        /// </summary>
        /// <value>The f fxi nav.</value>
        internal FFXINAV FFxiNav { get; set; }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public virtual void Save()
        {
        }

        /// <summary>
        /// Starts this instance.
        /// </summary>
        public virtual void Start()
        {
        }

        /// <summary>
        /// Stops the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public virtual void Stop(string msg = null)
        {
        }
    }
}