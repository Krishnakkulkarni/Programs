//-----------------------------------------------------------------------
// <copyright file="ConcreteObserver.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.Observer
{
    using System;
    /// <summary>
    /// Class for concreate observer
    /// </summary>
    /// <seealso cref="DesignPattern.Observer_Design_Pattern.Observer" />
    public class ConcreteObserver : Observer
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The observer state
        /// </summary>
        private string observerState;

        /// <summary>
        /// The subject
        /// </summary>
        private ConcreteSubject subject;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteObserver"/> class.
        /// </summary>
        /// <param name="subject">The subject.</param>
        /// <param name="name">The name.</param>
        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>
        /// The subject.
        /// </value>
        public ConcreteSubject Subject
        {
            get { return this.subject; }
            set { this.subject = value; }
        }

        /// <summary>
        /// Updates this instance.
        /// </summary>
        public override void Update()
        {
            try
            {
                this.observerState = this.subject.SubjectState;
                Console.WriteLine("Observer {0}'s new state is {1}", this.name, this.observerState);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
