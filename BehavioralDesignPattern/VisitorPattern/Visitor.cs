//-----------------------------------------------------------------------
// <copyright file="Visitor.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.VisitorPattern
{
    /// <summary>
    /// abstract class
    /// </summary>
    public abstract class Visitor
    {
        /// <summary>
        /// Visits the concrete element a.
        /// </summary>
        /// <param name="concreteElementA">The concrete element a.</param>
        public abstract void VisitConcreteElementA(ConcreteElementA concreteElementA);

        /// <summary>
        /// Visits the concrete element b.
        /// </summary>
        /// <param name="concreteElementB">The concrete element b.</param>
        public abstract void VisitConcreteElementB(ConcreteElementB concreteElementB);
    }
}
