//-----------------------------------------------------------------------
// <copyright file="IEmployee.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPatternProgram.CreationalDesignPattern.Prototype
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
        /// <returns>return interface</returns>
        IEmployee Clone();

        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <returns>return string</returns>
        string GetDetails();
    }
}
