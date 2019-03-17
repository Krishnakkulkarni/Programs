//-----------------------------------------------------------------------
// <copyright file="Node.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        /// <summary>
        /// 
        /// </summary>
        private Node<T> next;

        /// <summary>
        /// 
        /// </summary>
        private T data;

        /// <summary>
        /// 
        /// </summary>
        private long position;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="position"></param>
        public Node(T data, long position)
        {
            this.data = data;
            this.position = position;
        }

        /// <summary>
        /// 
        /// </summary>
        public Node<T> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public long Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public T Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
    }
}
