//-----------------------------------------------------------------------
// <copyright file="PrimeFactor.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// To find Prime Factor
    /// </summary>
    public class PrimeFactor
    {
        /// <summary>
        /// define the entry point of the application
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Primefactor()
        {  
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            UtilityClass.Primefactor(number);
        }
    }
}