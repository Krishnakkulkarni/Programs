//-----------------------------------------------------------------------
// <copyright file="Element.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.VisitorPattern
{
    /// <summary>
    /// abstract class
    /// </summary>
    public abstract class Element
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public abstract void Accept(Visitor visitor);
    }
}
