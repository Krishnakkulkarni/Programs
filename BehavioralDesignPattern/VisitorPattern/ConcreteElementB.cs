//-----------------------------------------------------------------------
// <copyright file="ConcreteElementB.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.VisitorPattern
{
    using System;

    /// <summary>
    /// Concrete ElementB
    /// </summary>
    /// <seealso cref="DesignPattern.Visitor_Design_Pattern.Element" />
    public class ConcreteElementB : Element
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public override void Accept(Visitor visitor)
        {
            try
            {
                //// Calling the visitor 
                visitor.VisitConcreteElementB(this);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Operations the b.
        /// </summary>
        public void OperationB()
        {
        }
    }
}
