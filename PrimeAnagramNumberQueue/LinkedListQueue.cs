//-----------------------------------------------------------------------
// <copyright file="LinkedListQueue.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DataStructurePrograms.PrimeAnagramNumberQueue
{
    using System;

    /// <summary>
    /// Class for Singly linked queue
    /// </summary>
    public class LinkedListQueue
    {
        /// <summary>
        /// The front
        /// </summary>
        private Node front;

        /// <summary>
        /// The rear
        /// </summary>
        private Node rear;

        /// <summary>
        /// The size
        /// </summary>
        private int size = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedListQueue"/> class.
        /// </summary>
        public LinkedListQueue()
        {
            this.front = this.rear = null;
            this.size = 0;
        }

        /// <summary>
        /// Enqueues the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Enqueue(object data)
        {
            try
            {
                Node newNode = new Node(data);

                // If queue is empty, then new node is front and rear both  
                if (this.rear == null)
                {
                    this.front = this.rear = newNode;
                }
                else
                {
                    // Add the new node at the end of queue and change rear  
                    Node temp = this.rear.GetNext();
                    temp = newNode;
                    this.rear = newNode;
                }

                this.size++;
                Console.Write(data + " ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Dequeue this instance.
        /// </summary>
        public void Dequeue()
        {
            try
            {
                // If queue is empty, return NULL.  
                if (this.front == null)
                {
                    Console.WriteLine("The Queue is empty");
                    return;
                }

                // Store previous front and move front one node ahead  
                Node temp = this.front;
                this.front = this.front.GetNext();

                // If front becomes NULL, then change rear also as NULL  
                if (this.front == null)
                {
                    this.rear = null;
                }

                this.size--;

                //// Prints the deleted data
                Console.WriteLine("Item deleted is {0}", temp.GetData());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            //// Taking temp variable as empty string

            try
            {
                if (this.IsEmpty())
                {
                    Console.WriteLine("The queue is empty");
                }

                //// Node is pointing to the raer
                Node temp = this.rear;

                //// Loops over till last node is null
                //// Loops over till the last node is null
                while (temp != null)
                {
                    Console.Write(temp.GetData() + " ");
                    temp = temp.GetNext();
                }

                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Counts this instance.
        /// </summary>
        /// <returns>returns count</returns>
        public int Count()
        {
            return this.size;
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            //// checks for the size is empty
            if (this.size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
