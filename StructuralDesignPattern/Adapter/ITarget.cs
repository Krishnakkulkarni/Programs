//-----------------------------------------------------------------------
// <copyright file="ITarget.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.StructuralDesignPattern.Adapter
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The 'ITarget' interface
    /// </summary>
    public interface ITarget
    {
        /// <summary>
        /// Gets the employee list.
        /// </summary>
        /// <returns></returns>
        List<string> GetStudentList();
    }
}
