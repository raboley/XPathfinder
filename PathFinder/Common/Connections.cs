// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created :
// Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 03-23-2020 Last Modified On : 04-12-2020 Last
// Last Modified On : 07-13-2020 ***********************************************************************
// <copyright file="Connections.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
namespace PathFinder.Common
{
    /// <summary>
    /// Class Connection.
    /// </summary>
    public class Connection
    {
        /// <summary>
        /// To
        /// </summary>
        public position_t To;

        /// <summary>
        /// The length
        /// </summary>
        public float Length;

        /// <summary>
        /// Initializes a new instance of the <see cref="Connection"/> class.
        /// </summary>
        /// <param name="to">To.</param>
        /// <param name="length">The length.</param>
        public Connection(position_t to, float length)
        {
            To = to;
            Length = length;
        }
    }
}