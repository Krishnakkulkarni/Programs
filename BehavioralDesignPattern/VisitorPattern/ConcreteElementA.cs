//-----------------------------------------------------------------------
// <copyright file="ConcreteElementA.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.VisitorPattern
{
    using System;

    /// <summary>
    /// Concrete ElementA
    /// </summary>
    /// <seealso cref="DesignPattern.Visitor_Design_Pattern.Element" />
    public class ConcreteElementA : Element
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public override void Accept(Visitor visitor)
        {
            try
            {
                //// Calling the visitor method
                visitor.VisitConcreteElementA(this);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Operations a.
        /// </summary>
        public void OperationA()
        {
        }
    }
}
