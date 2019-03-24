//-----------------------------------------------------------------------
// <copyright file="Typist.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.CreationalDesignPattern.Prototype
{
    using System;

    /// <summary>
    /// Typist class implements IEmployee interface
    /// </summary>
    /// <seealso cref="DesignPattern.CreationalDesignPattern.Prototype.IEmployee" />
    public class Typist : IEmployee
    {
        /// <summary>
        /// Gets or sets the words per minute.
        /// </summary>
        /// <value>
        /// The words per minute.
        /// </value>
        public int WordsPerMinute { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the role.
        /// </summary>
        /// <value>
        /// The role.
        /// </value>
        public string Role { get; set; }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>return interface</returns>
        public IEmployee Clone()
        {
            //// Shallow Copy: only top-level objects are duplicated
            return (IEmployee)MemberwiseClone();

            //// Deep Copy: all objects are duplicated
            //// return (IEmployee)this.Clone();
        }

        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <returns>return string</returns>
        public string GetDetails()
        {
            return string.Format("{0} - {1} - {2}wpm", this.Name, this.Role, this.WordsPerMinute);
        }
    }
}
