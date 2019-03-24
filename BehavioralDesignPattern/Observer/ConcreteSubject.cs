﻿//-----------------------------------------------------------------------
// <copyright file="ConcreteSubject.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.Observer
{
    using System;

    /// <summary>
    /// ConcreteSubject
    /// </summary>
    /// <seealso cref="DesignPattern.Observer_Design_Pattern.Subject" />
    public class ConcreteSubject : Subject
    {
        /// <summary>
        /// The subject state
        /// </summary>
        private string subjectState;

        /// <summary>
        /// Gets or sets the state of the subject.
        /// </summary>
        /// <value>
        /// The state of the subject.
        /// </value>
        public string SubjectState
        {
            get { return this.subjectState; }
            set { this.subjectState = value; }
        }
    }
}
