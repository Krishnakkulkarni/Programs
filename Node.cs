//-----------------------------------------------------------------------
// <copyright file="Node.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DataStructurePrograms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class Node of Ordered List
    /// </summary>
    public class Node
    {
        /// <summary>
        /// The data
        /// </summary>
        private object data;

        /// <summary>
        /// The next
        /// </summary>
        private Node next;

        public object Next { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="o">The o.</param>
        /// <param name="n">The n.</param>
        public Node(object o, Node n)
        {
            this.data = o;
            this.next = n;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="o">The o.</param>
        public Node(object o)
        {
            this.data = o;
        }

        /// <summary>
        /// Sets the data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void SetData(object data)
        {
            this.data = data;
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns>returns data</returns>
        public object GetData()
        {
            return this.data;
        }

        /// <summary>
        /// Sets the next.
        /// </summary>
        /// <param name="n">The n.</param>
        public void SetNext(Node n)
        {
            this.next = n;
        }

        /// <summary>
        /// Gets the next.
        /// </summary>
        /// <returns>returns next</returns>
        public Node GetNext()
        {
            return this.next;
        }
    }
}