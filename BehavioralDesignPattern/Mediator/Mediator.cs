//-----------------------------------------------------------------------
// <copyright file="Mediator.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.Mediator
{
    /// <summary>
    /// Abstract Mediator class
    /// </summary>
    public abstract class Mediator
    {
        /// <summary>
        /// Sends the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="colleague">The colleague.</param>
        public abstract void Send(string message, Colleague colleague);
    }
}
