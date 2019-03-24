//-----------------------------------------------------------------------
// <copyright file="ConcreteMediator.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.Mediator
{
    using System;

    /// <summary>
    /// Class for concrete mediator
    /// </summary>
    /// <seealso cref="DesignPattern.Mediator_Design_Pattern.Mediator" />
    public class ConcreteMediator : Mediator
    {
        /// <summary>
        /// The colleague1
        /// </summary>
        private ConcreteColleague1 colleague1;

        /// <summary>
        /// The colleague2
        /// 
        /// 
        /// </summary>
        private ConcreteColleague2 colleague2;

        /// <summary>
        /// Sets the colleague1.
        /// </summary>
        /// <value>
        /// The colleague1.
        /// </value>
        public ConcreteColleague1 Colleague1
        {
            set { this.colleague1 = value; }
        }

        /// <summary>
        /// Sets the colleague2.
        /// </summary>
        /// <value>
        /// The colleague2.
        /// </value>
        public ConcreteColleague2 Colleague2
        {
            set { this.colleague2 = value; }
        }

        /// <summary>
        /// Sends the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="colleague">The colleague.</param>
        public override void Send(string message, Colleague colleague)
        {
            try
            {
                //// Checks if its equal to colleague1 or colleague2
                if (colleague == this.colleague1)
                {
                    this.colleague2.Notify(message);
                }
                else
                {
                    this.colleague1.Notify(message);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
