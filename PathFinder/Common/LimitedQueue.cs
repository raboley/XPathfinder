// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 04-03-2020 Created : 04-03-2020 Created : 04-03-2020 Created :
// Created : 04-03-2020 Created : 04-03-2020 Created : 04-03-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 04-03-2020 Last Modified On : 04-12-2020 Last
// Last Modified On : 07-13-2020 ***********************************************************************
// <copyright file="LimitedQueue.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using System.Collections.Generic;

namespace PathFinder.Common
{
    /// <summary>
    /// Class LimitedQueue. Implements the <see cref="System.Collections.Generic.Queue{T}"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="System.Collections.Generic.Queue{T}"/>
    public class LimitedQueue<T> : Queue<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LimitedQueue{T}"/> class.
        /// </summary>
        /// <param name="limit">The limit.</param>
        public LimitedQueue(int limit)
            : base(limit)
        {
            Limit = limit;
        }

        /// <summary>
        /// Gets or sets the limit.
        /// </summary>
        /// <value>The limit.</value>
        public int Limit { get; set; }

        /// <summary>
        /// Enqueues the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public new void Enqueue(T item)
        {
            while (Count >= Limit)
            {
                Dequeue();
            }
            base.Enqueue(item);
        }
    }
}