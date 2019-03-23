//-----------------------------------------------------------------------
// <copyright file="Singleton.cs" company="Bridgelabz">
//     Company @ 2018 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DesigenPattern.CreationalPattern
{
    using System;

    /// <summary>
    /// Making class as sealed
    /// </summary>
    public sealed class Singleton
    {
        /*
        /// <summery>
        /// Using Non-Lazy/eager initialization
        /// </summery>
        /// private static readonly Singleton instance = new Singleton();
         */

        /// <summary>
        /// Instantiation of object
        /// Using for thread safety
        /// </summary>
        private static readonly object Obj = new object();

        /// <summary>
        /// Declaration and initialization of count globally
        /// </summary>
        private static int count = 0;

        /*
        /// <summary>
        /// Lazy initialization using Lazy Keyword
        /// </summary>
        /// private static readonly Lazy<Singleton> Instance = new Lazy<Singleton>(() => new Singleton());
        */

        /// <summary>
        /// Using lazy initialization
        /// </summary>
        private static Singleton instance = null;

        /// <summary>
        /// Prevents a default instance of the <see cref="Singleton"/> class from being created
        /// </summary>
        private Singleton()
        {
            count++;
            Console.WriteLine("count {0}", count.ToString());
        }

        /// <summary>
        /// Instance of Get instance
        /// </summary>
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (Obj)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton(); 
                        }
                        //// return instance;
                        //// return instance.Value;
                    }
                }

                return instance;
            } 
        }

        /// <summary>
        /// Method to print Message
        /// </summary>
        /// <param name="message">message as a parameter</param>
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
