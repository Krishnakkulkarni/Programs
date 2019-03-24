//-----------------------------------------------------------------------
// <copyright file="Subject.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.Observer
{
    using System;

    using System.Collections.Generic;

    /// <summary>
    /// Class for Subject
    /// </summary>
    public abstract class Subject
    {
        /// <summary>
        /// The observers
        /// </summary>
        private List<Observer> observers = new List<Observer>();

        /// <summary>
        /// Attaches the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void Attach(Observer observer)
        {
            this.observers.Add(observer);
        }

        /// <summary>
        /// Detaches the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void Detach(Observer observer)
        {
            try
            {
                this.observers.Remove(observer);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        public void Notify()
        {
            try
            {
                //// Loops over the observer
                foreach (Observer observe in this.observers)
                {
                    observe.Update();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
