//-----------------------------------------------------------------------
// <copyright file="Node.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DataStructurePrograms.Unordered
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Generic ListNode class - avoiding boxing unboxing here by using generic implementation
    /// </summary>
    /// <typeparam name="T">Generics parameter</typeparam>
        public class Node<T>
        {
            /// <summary>
            /// The next
            /// </summary>
            private Node<T> next;

            /// <summary>
            /// The data
            /// </summary>
            private T data;

            /// <summary>
            /// The position
            /// </summary>
            private long position;

            /// <summary>
            /// Initializes a new instance of the <see cref="Node{T}"/> class.
            /// </summary>
            /// <param name="data">The data.</param>
            /// <param name="position">The position.</param>
            public Node(T data, long position)
            {
                this.position = position;
                this.data = data;
            }

            /// <summary>
            /// Gets or sets the next.
            /// </summary>
            /// <value>
            /// The next.
            /// </value>
            public Node<T> Next
            {
                get { return this.next; }
                set { this.next = value; }
            }

            /// <summary>
            /// Gets or sets the position.
            /// </summary>
            /// <value>
            /// The position.
            /// </value>
            public long Position
            {
                get { return this.position; }
                set { this.position = value; }
            }

            /// <summary>
            /// Gets or sets the data.
            /// </summary>
            /// <value>
            /// The data.
            /// </value>
            public T Data
            {
                get { return this.data; }
                set { this.data = value; }
            }
        }
}