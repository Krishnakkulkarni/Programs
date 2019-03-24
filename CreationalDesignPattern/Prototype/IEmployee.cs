//-----------------------------------------------------------------------
// <copyright file="IEmployee.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.CreationalDesignPattern.Prototype
{
    using System;

    /// <summary>
    /// The prototype interface
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>returns interface</returns>
        IEmployee Clone();

        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <returns>returns string</returns>
        string GetDetails();
    }
}
