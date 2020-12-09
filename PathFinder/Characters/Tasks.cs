// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 04-03-2020 Created : 04-03-2020 Created : 04-03-2020 Created :
// Created : 04-03-2020 Created : 04-03-2020 Created : 04-03-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 04-04-2020 Last Modified On : 04-12-2020 Last
// Last Modified On : 07-13-2020 ***********************************************************************
// <copyright file="Tasks.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using PathFinder.Contracts;
using PathFinder.Tasks.Nav;
using PathFinder.Tasks.Random;
using System.Collections.Generic;
using System.Linq;

namespace PathFinder.Characters
{
    /// <summary>
    /// Class Tasks.
    /// </summary>
    public class Tasks
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tasks"/> class.
        /// </summary>
        /// <param name="Character">The character.</param>
        public Tasks(Character Character)
        {
            Initialize(Character);
        }

        /// <summary>
        /// Gets the nav task.
        /// </summary>
        /// <value>The nav task.</value>
        public RandomPathTask RandomPathTask { get; private set; }

        /// <summary>
        /// Gets the nav task.
        /// </summary>
        /// <value>The nav task.</value>
        public NavTask NavTask { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance is busy.
        /// </summary>
        /// <value><c>true</c> if this instance is busy; otherwise, <c>false</c>.</value>
        public bool IsBusy
        {
            get
            {
                return TaskList.Any(t => t.IsBusy);
            }
        }

        /// <summary>
        /// Gets or sets the task list.
        /// </summary>
        /// <value>The task list.</value>
        private List<ITask> TaskList { get; set; }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            foreach (var task in TaskList)
            {
                task.Save();
            }
        }

        /// <summary>
        /// Starts this instance.
        /// </summary>
        public void Start()
        {
            foreach (var task in TaskList)
            {
                task.Start();
            }
        }

        /// <summary>
        /// Stops this instance.
        /// </summary>
        public void Stop()
        {
            foreach (var task in TaskList)
            {
                task.Stop();
            }
        }

        /// <summary>
        /// Initializes the specified character.
        /// </summary>
        /// <param name="Character">The character.</param>
        private void Initialize(Character Character)
        {
            TaskList = new List<ITask>
            {
                (RandomPathTask = new RandomPathTask(Character)),
                (NavTask = new NavTask(Character)),
            };
        }
    }
}