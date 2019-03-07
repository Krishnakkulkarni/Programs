//-----------------------------------------------------------------------
// <copyright file="SinglyLinkedList.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni"/>
//-----------------------------------------------------------------------
namespace DataStructurePrograms.OrderedList
{
    using System;

    /// <summary>
    /// Class SinglyLinkedList of Ordered List
    /// </summary>
    public class SinglyLinkedList
    {
        /// <summary>
        /// Node is null
        /// </summary>
        private Node first;

        /// <summary>
        /// Size is null
        /// </summary>
        private int size = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="SinglyLinkedList"/> class.
        /// </summary>
        public SinglyLinkedList()
        {
            this.first = null;
            this.size = 0;
        }

        /// <summary>
        /// Adds the specified data
        /// </summary>
        /// <param name="data">The data.</param>
        public void Add(object data)
        {
            try
            {
                //// Checks for the size is 0
                if (this.IsEmpty())
                {
                    this.first = new Node(data, null);
                    this.size++;
                }
                else
                {
                    //// initializing first node as current node
                    Node current = this.first;
                    Node temp = new Node(data, null);

                    //// Loops over till the current node pointer is not null
                    while (current.GetNext() != null)
                    {
                        //// Current node points to the next pointer
                        current = current.GetNext();
                    }

                    // temp.SetNext(current);
                    current.SetNext(temp);
                    this.size++;
                }
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
            try
            {
                //// Checks for the list is empty or not
                if (this.IsEmpty())
                {
                    Console.WriteLine("Empty Linked List");
                }

                //// Declaring first node as temporarory node 
                Node temp = this.first;

                //// Loops over till the last node is null
                while (temp != null)
                {
                    Console.Write(" {0}", temp.GetData());
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
        /// to search the element
        /// </summary>
        /// <param name="element">element name</param>
        /// <returns>returns element</returns>
        public bool Search(object element)
        {
            try
            {
                //// Takeing the first node as temporary
                Node temp = this.first;

                //// Loops over till temp null
                while (temp != null)
                {
                    //// Checks if data is equal to the elemnt in file   
                    if (temp.GetData().Equals(element))
                    {
                        return true;
                    }

                    //// Temp points to the next element
                    temp = temp.GetNext();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return false;
        }

        /// <summary>
        /// Removes the specified singly linked list.
        /// </summary>
        /// <param name="singlyLinkedList">The singly linked list.</param>
        /// <param name="element">The element.</param>
        public void Remove(SinglyLinkedList singlyLinkedList, object element)
        {
            try
            {
                Node temp = singlyLinkedList.first;
                Node prev = temp;
                //// checks if the temp node is the element present

                if (temp.GetData() == element)
                {
                    singlyLinkedList.first = temp.GetNext();
                }

                while (temp != null)
                {
                    if (temp.GetData().Equals(element))
                    {
                        prev.SetNext(temp.GetNext());
                        return;
                    }

                    prev = temp;
                    temp = temp.GetNext();
                }
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
        /// Files the path unordered.
        /// </summary>
        /// <returns>string array</returns>
        public string FilePathUnordered()
        {
            //// Path is set to null
            string path = null;
            try
            {
                path = @"Text.txt";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return path;
        }

        /// <summary>
        /// Strings to string array.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>string array</returns>
        public string[] StringToStringArray(string s)
        {
            int count = 0, i = 0;

            //// seperating words to charachter
            foreach (char char1 in s)
            {
                if (char1 == ' ')
                {
                    count++;
                }
            }

            //// Stores the word in array
            string[] stringarray = new string[count + 1];
            string temp = string.Empty;

            //// Loops over to print the array
            foreach (char c in s)
            {
                //// if space is encountered we store it to next element
                if (c == ' ')
                {
                    stringarray[i] = temp;
                    temp = string.Empty;
                    i++;
                }
                else
                {
                    temp = temp + c;
                }

                stringarray[i] = temp;
            }

            return stringarray;
        }
    }
}