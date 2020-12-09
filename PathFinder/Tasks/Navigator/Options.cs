// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 04-03-2020 Created : 04-03-2020 Created : 04-03-2020 Created :
// Created : 04-03-2020 Created : 04-03-2020 Created : 04-03-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 04-04-2020 Last Modified On : 04-12-2020 Last
// Last Modified On : 07-13-2020 ***********************************************************************
// <copyright file="Options.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using PathFinder.Common;
using System.Collections.Generic;

namespace PathFinder.Tasks.Nav
{
    /// <summary>
    /// Class Options.
    /// </summary>
    public class Options
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Options"/> class.
        /// </summary>
        public Options()
        {
            Targets = new List<string>();
            Points = new List<PointsOfInterest>();
            Ppoint = new PointsOfInterest();
            WayPoints = new List<position_t>();
            Zones = new List<Zones>();
        }

        /// <summary>
        /// Gets or sets the zones.
        /// </summary>
        /// <value>The zones.</value>
        public List<Zones> Zones { get; set; }

        /// <summary>
        /// Gets or sets the way points.
        /// </summary>
        /// <value>The way points.</value>
        public List<position_t> WayPoints { get; set; }

        /// <summary>
        /// The posi
        /// </summary>
        public position_t Posi = new position_t();

        /// <summary>
        /// The keep moving start posi
        /// </summary>
        public position_t KeepMovingStartPosi = new position_t();

        /// <summary>
        /// Gets or sets the ppoint.
        /// </summary>
        /// <value>The ppoint.</value>
        public PointsOfInterest Ppoint { get; set; }

        /// <summary>
        /// Gets or sets the dist.
        /// </summary>
        /// <value>The dist.</value>
        public double dist { get; set; } = 0;

        /// <summary>
        /// Gets or sets the search distance.
        /// </summary>
        /// <value>The search distance.</value>
        public int SearchDistance { get; set; } = 50;

        /// <summary>
        /// Gets or sets the points.
        /// </summary>
        /// <value>The points.</value>
        public List<PointsOfInterest> Points { get; set; }

        /// <summary>
        /// Gets or sets the targets.
        /// </summary>
        /// <value>The targets.</value>
        public List<string> Targets { get; set; }

        /// <summary>
        /// Gets or sets the idle delay.
        /// </summary>
        /// <value>The idle delay.</value>
        public int IdleDelay { get; set; } = 60;

        /// <summary>
        /// Gets or sets the old string.
        /// </summary>
        /// <value>The old string.</value>
        public string oldString { get; set; }

        /// <summary>
        /// Gets or sets the pull distance.
        /// </summary>
        /// <value>The pull distance.</value>
        public int PullDistance { get; set; } = 12;

        /// <summary>
        /// Gets or sets the destination.
        /// </summary>
        /// <value>The destination.</value>
        public position_t Destination { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [stop running].
        /// </summary>
        /// <value><c>true</c> if [stop running]; otherwise, <c>false</c>.</value>
        public bool StopRunning { get; set; } = false;
    }
}