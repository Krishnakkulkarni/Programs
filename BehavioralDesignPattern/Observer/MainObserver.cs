//-----------------------------------------------------------------------
// <copyright file="MainObserver.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.Observer
{
    using System;

    /// <summary>
    /// Class for main Observer
    /// </summary>
    public class MainObserver
    {
        /// <summary>
        /// Observers this instance.
        /// </summary>
        public static void Observer()
        {
            try
            {
                //// Configure Observer pattern
                ConcretSubject subject = new ConcretSubject();

                subject.Attach(new ConcretObserver(subject, "X"));
                subject.Attach(new ConcretObserver(subject, "Y"));
                subject.Attach(new ConcretObserver(subject, "Z"));

                //// Change subject and notify observers
                subject.SubjectState = "ABC";

                //// Wait for the user
                subject.Notify();

                Console.ReadKey();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
