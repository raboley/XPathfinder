// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 04-11-2020 Created : 04-11-2020 Created : 04-11-2020 Created :
// Created : 04-11-2020 Created : 04-11-2020 Created : 04-11-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 04-12-2020 Last Modified On : 07-04-2020 Last
// Modified On : 07-13-2020 ***********************************************************************
// <copyright file="Zone.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using System.Xml.Serialization;

namespace PathFinder.Common
{
    /// <summary>
    /// Class Zones.
    /// </summary>
    public class Zones
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [XmlAttribute("ID")]
        public int id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [XmlAttribute("Name")]
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the Path.
        /// </summary>
        /// <value>The Path.</value>
        [XmlAttribute("Path")]
        public string path { get; set; }
    }
}