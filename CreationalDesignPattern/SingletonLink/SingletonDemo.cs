//-----------------------------------------------------------------------
// <copyright file="SingletonDemo.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.CreationalDesignPattern
{
    using System;

    /// <summary>
    /// Singleton demo class
    /// </summary>
    public class SingletonDemo
    {
        /// <summary>
        /// sealed singleton class
        /// </summary>
        public sealed class Singleton
        {
            //// Lazy initialization
            //// private static Singleton instance = null;

            //// Eager initialization  
            
            /// <summary>
            /// The instance
            /// </summary>
            private static readonly Singleton Instance = new Singleton();

            /// <summary>
            /// The counter
            /// </summary>
            private static int counter = 0;

            /// <summary>
            /// Prevents a default instance of the <see cref="Singleton"/> class from being created.
            /// </summary>
            private Singleton()
            {
                counter++;
                Console.WriteLine("Counter value: " + counter.ToString());
            }

            /// <summary>
            /// Gets the get instance.
            /// </summary>
            /// <value>
            /// The get instance.
            /// </value>
            public static Singleton GetInstance
            {
                get
                {
                    /*if(Instance == null)
                    {
                        Instance = new Singleton();
                    }*/
                    return Instance;
                }
            }
            
            /// <summary>
            /// Prints the details.
            /// </summary>
            /// <param name="message">The message.</param>
            public void PrintDetails(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
}
