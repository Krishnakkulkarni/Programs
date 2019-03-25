//-----------------------------------------------------------------------
// <copyright file="Observer.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.Observer
{
    using System;

    /// <summary>
    /// Abstract class 
    /// </summary>
    public abstract class Observer
    {
        /// <summary>
        /// Updates this instance.
        /// </summary>
        public abstract void Update();
    }
}
