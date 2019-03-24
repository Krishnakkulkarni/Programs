//-----------------------------------------------------------------------
// <copyright file="ObjectStructure.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.VisitorPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Object Structure
    /// </summary>
    public class ObjectStructure
    {
        /// <summary>
        /// The elements
        /// </summary>
        private List<Element> elements = new List<Element>();

        /// <summary>
        /// Attaches the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        public void Attach(Element element)
        {
            try
            {
                //// Elements that needs to be added
                this.elements.Add(element);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Detaches the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        public void Detach(Element element)
        {
            try
            {
                //// Elements that needs to be removed
                this.elements.Remove(element);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public void Accept(Visitor visitor)
        {
            try
            {
                //// Loops over to get the elements
                foreach (Element element in this.elements)
                {
                    element.Accept(visitor);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
