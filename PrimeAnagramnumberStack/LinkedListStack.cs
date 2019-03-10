//-----------------------------------------------------------------------
// <copyright file="LinkedListStack.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DataStructurePrograms.PrimeAnagramnumberStack
{
    using System;

    /// <summary>
    /// LinkedList Class
    /// </summary>
    public class LinkedListStack
    {
        /// <summary>
        /// Define the top node
        /// </summary>
        private Node top;

        /// <summary>
        /// The size
        /// </summary>
        private int size = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedListStack"/> class.
        /// </summary>
        public LinkedListStack()
        {
            //// Initializes the top of stack to null
            this.top = null;
            this.size = 0;
        }

        /// <summary>
        /// Pushes the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void Push(object value)
        {
            try
            {
                //// Creating a node object
                Node newNode = new Node(value);

                //// Checks for top node is null and if its not null points to the next elemet
                if (this.top == null)
                {
                    //// Node points to next node
                    Node temp = newNode.GetNext();
                    temp = null;
                }
                else
                {
                    //// Temp points to the next node
                    Node temp = newNode.GetNext();
                    this.top = temp;
                }

                //// takes the count of element entered into stack
                this.size++;
                this.top = newNode;
                Console.Write(value + " ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Pops this instance.
        /// </summary>
        public void Pop()
        {
            try
            {
                //// Checks if stack is null
                if (this.top == null)
                {
                    Console.WriteLine("Stack Underflow. Deletion not possible");
                    return;
                }

                this.size--;

                //// Displays the popped element
                Console.WriteLine("Item popped is {0}" + this.top.GetData());

                //// Points to the next element
                this.top = this.top.GetNext();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Peeks this instance.
        /// </summary>
        public void Peek()
        {
            try
            {
                //// Checks if stack is null
                if (this.top == null)
                {
                    Console.WriteLine("Stack Underflow. Deletion not possible");
                    return;
                }
                //// Chceks for top is empty
                if (this.top == null)
                {
                    //// Displays stack underflow message
                    Console.WriteLine("Stack Underflow.");
                    return;
                }

                Console.WriteLine("{0} is on the top of Stack", this.top.GetData());
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

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            try
            {
                //// Checks for the list is empty or not
                if (this.IsEmpty())
                {
                    Console.WriteLine("Empty Linked List");
                }

                //// Declaring first node as temporarory node 
                Node temp = this.top;
                string string1 = " ";

                //// Loops over till the last node is null
                while (temp != null)
                {
                    string1 = string1 + " " + temp.GetData();
                    Console.WriteLine(string1);
                    temp = temp.GetNext();
                }

                // Console.WriteLine(s);
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
