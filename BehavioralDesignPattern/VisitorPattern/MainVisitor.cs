//-----------------------------------------------------------------------
// <copyright file="MainVisitor.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.VisitorPattern
{
    using System;

    /// <summary>
    /// Main Visitor
    /// </summary>
    public class MainVisitor
    {
        /// <summary>
        /// Visitors this instance.
        /// </summary>
        public static void Visitor()
        {
            try
            {
                ObjectStructure object1 = new ObjectStructure();
                object1.Attach(new ConcreteElementA());
                object1.Attach(new ConcreteElementB());

                //// Create visitor objects
                ConcreteVisitor1 visitor1 = new ConcreteVisitor1();
                ConcreteVisitor2 visitor2 = new ConcreteVisitor2();

                //// Structure accepting visitors
                object1.Accept(visitor1);
                object1.Accept(visitor2);

                //// Wait for user
                Console.ReadKey();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
