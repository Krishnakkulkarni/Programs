//-----------------------------------------------------------------------
// <copyright file="Colleague.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.Mediator
{
    using System;

    /// <summary>
    /// Abstract class for colleague
    /// </summary>
    public abstract class Colleague
    {
        /// <summary>
        /// The mediator
        /// </summary>
        protected readonly Mediator Mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="Colleague"/> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        public Colleague(Mediator mediator)
        {
            try
            {
                this.Mediator = mediator;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
