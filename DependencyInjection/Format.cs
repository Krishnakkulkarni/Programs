// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Format.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Krishna kulkarni"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class to implement interface
    /// </summary>
    /// <seealso cref="Implementations.Text" />
    public class Format : IText
    {
        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            try
            {
            Console.WriteLine(" here is text format");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
