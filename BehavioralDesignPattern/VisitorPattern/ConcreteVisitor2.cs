﻿//-----------------------------------------------------------------------
// <copyright file="ConcreteVisitor2.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.VisitorPattern
{
    using System;

    /// <summary>
    /// Concrete Visitor2
    /// </summary>
    /// <seealso cref="DesignPattern.Visitor_Design_Pattern.Visitor" />
    public class ConcreteVisitor2 : Visitor
    {
        /// <summary>
        /// Visits the concrete element a.
        /// </summary>
        /// <param name="concreteElementA">The concrete element a.</param>
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            try
            {
                //// Prints the values
                Console.WriteLine("{0} visited by {1}", concreteElementA.GetType().Name, this.GetType().Name);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Visits the concrete element b.
        /// </summary>
        /// <param name="concreteElementB">The concrete element b.</param>
        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            try
            {
                //// Prints the value
                Console.WriteLine("{0} visited by {1}", concreteElementB.GetType().Name, this.GetType().Name);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
