//-----------------------------------------------------------------------
// <copyright file="Stack.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DataStructurePrograms.CalendarStack
{
    using System;

    /// <summary>
    /// stack class
    /// </summary>
    public class Stack
    {
        /// <summary>
        /// The maximum size
        /// </summary>
        private int maxSize;

        /// <summary>
        /// The stack array
        /// </summary>
        private int[] stackArray;

        /// <summary>
        /// The top
        /// </summary>
        private int top;

        /// <summary>
        /// Stacks the initialize.
        /// </summary>
        /// <param name="stackSize">Size of the stack.</param>
        public void StackInitialise(int stackSize)
        {
            try
            {
                this.maxSize = stackSize;
                this.stackArray = new int[this.maxSize];
                this.top = -1;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Pushes the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <exception cref="Exception">Handles and throws Exception</exception>
        public void Push(int data)
        {
            try
            {
                this.top++; ////increasing top value after pushing each element
                this.stackArray[this.top] = data;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Pops this instance.
        /// </summary>
        /// <returns> returns the top element from the stack</returns>
        public int Pop()
        {
            try
            {
                if (this.top == 1)
                {
                    return 0;
                }

                this.top--; ////decreasing top value after pushing each element
                return this.stackArray[this.top];
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Peeks this instance.
        /// </summary>
        /// <returns>returns the top element</returns>
        public int Peek()
        {
            try
            {
                return this.stackArray[this.top]; //// returns the top most element in stack
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
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
            try
            {
                return this.top == -1; //// if top value equals to -1,it means the stack is empty.
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Determines whether this instance is full.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is full; otherwise, <c>false</c>.
        /// </returns>
        public bool IsFull()
        {
            try
            {
                return this.top == this.maxSize - 1;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}