//-----------------------------------------------------------------------
// <copyright file="ConcretColleague1.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.Mediator
{
    using System;

    /// <summary>
    /// Class for concret colleague
    /// </summary>
    /// <seealso cref="DesignPattern.Mediator_Design_Pattern.Colleague" />
    public class ConcretColleague1 : Colleague
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcretColleague1"/> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        public ConcretColleague1(Mediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// Sends the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Send(string message)
        {
            try
            {
                Mediator.Send(message, this);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Notifies the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Notify(string message)
        {
            try
            {
                Console.WriteLine("Colleague1 gets message: " + message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
