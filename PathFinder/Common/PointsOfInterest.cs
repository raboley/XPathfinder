// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 03-25-2020 Created : 03-25-2020 Created : 03-25-2020 Created :
// Created : 03-25-2020 Created : 03-25-2020 Created : 03-25-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 04-03-2020 Last Modified On : 04-12-2020 Last
// Last Modified On : 07-13-2020 ***********************************************************************
// <copyright file="PointsOfInterest.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using System.Xml.Serialization;

namespace PathFinder.Common
{
    /// <summary>
    /// Class PointsOfInterest.
    /// </summary>
    public class PointsOfInterest
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [XmlAttribute("id")]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the x.
        /// </summary>
        /// <value>The x.</value>
        [XmlAttribute("x")]
        public float X { get; set; }

        /// <summary>
        /// Gets or sets the y.
        /// </summary>
        /// <value>The y.</value>
        [XmlAttribute("y")]
        public float Y { get; set; }

        /// <summary>
        /// Gets or sets the z.
        /// </summary>
        /// <value>The z.</value>
        [XmlAttribute("z")]
        public float Z { get; set; }
    }
}