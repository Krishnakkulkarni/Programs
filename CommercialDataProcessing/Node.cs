//-----------------------------------------------------------------------
// <copyright file="Node.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    using System;

    /// <summary>
    /// Class for Linked List
    /// </summary>
    /// <typeparam name="T">Generic type T</typeparam>
    public class Node<T>
    {
        /// <summary>
        /// Instance of Node
        /// </summary>
        private Node<T> next;

        /// <summary>
        /// Instance of data
        /// </summary>
        private T data;

        /// <summary>
        /// Instance of position
        /// </summary>
        private long position;

        /// <summary>
        /// Instance of Node
        /// </summary>
        /// <param name="data">data as a parameter</param>
        /// <param name="position">position as a parameter</param>
        public Node(T data, long position)
        {
            this.data = data;
            this.position = position;
        }

        /// <summary>
        /// Instance of Next
        /// </summary>
        public Node<T> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        /// <summary>
        /// Instance of Position
        /// </summary>
        public long Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        /// <summary>
        /// Instance of Data
        /// </summary>
        public T Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
    }
}
