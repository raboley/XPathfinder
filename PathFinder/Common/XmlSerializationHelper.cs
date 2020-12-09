// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created :
// Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 03-16-2020 Last Modified On : 04-12-2020 Last
// Last Modified On : 07-13-2020 ***********************************************************************
// <copyright file="XmlSerializationHelper.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using System.IO;
using System.Xml.Serialization;

namespace PathFinder.Common
{
    /// <summary>
    /// Class XmlSerializationHelper.
    /// </summary>
    public class XmlSerializationHelper
    {
        /// <summary>
        /// Deserializes the specified filename.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename">The filename.</param>
        /// <returns>T.</returns>
        public static T Deserialize<T>(string filename)
        {
            try
            {
                var xs = new XmlSerializer(typeof(T));

                using (var rd = new StreamReader(filename))
                {
                    return (T)xs.Deserialize(rd);
                }
            }
            catch
            {
                return default(T);
            }
        }

        /// <summary>
        /// Serializes the specified filename.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename">The filename.</param>
        /// <param name="obj">The object.</param>
        public static void Serialize<T>(string filename, T obj)
        {
            var xs = new XmlSerializer(typeof(T));

            var dir = Path.GetDirectoryName(filename);

            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            using (var sw = new StreamWriter(filename))
            {
                xs.Serialize(sw, obj);
            }
        }
    }
}