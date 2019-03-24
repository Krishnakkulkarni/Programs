//-----------------------------------------------------------------------
// <copyright file="ConcreteColleague2.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.Mediator
{
    using System;

    /// <summary>
    /// class Concrete Colleague2
    /// </summary>
    /// <seealso cref="DesignPattern.Mediator_Design_Pattern.Colleague" />
    public class ConcreteColleague2 : Colleague
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteColleague2"/> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        public ConcreteColleague2(Mediator mediator)
          : base(mediator)
        {
        }

        /// <summary>
        /// Sends the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        /// <summary>
        /// Notifies the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Notify(string message)
        {
            try
            {
                Console.WriteLine("Colleague2 gets message: " + message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
