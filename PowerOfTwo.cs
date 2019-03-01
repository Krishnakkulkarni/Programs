//-----------------------------------------------------------------------
// <copyright file="PowerOfTwo.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
 using System;

    /// <summary>
    /// Power of two
    /// </summary>
    public class PowerOfTwo
    {
        /// <summary>
        /// define the entry point of the application
        /// </summary>
        /// <param name="number">The arguments.</param>
        public static void TwoToThePower()
        {
            Console.WriteLine("enter the number");
            double number = Convert.ToDouble(Console.ReadLine());
            UtilityClass.PowerOftwo(number);
        }
    }
}