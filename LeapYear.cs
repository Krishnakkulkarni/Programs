//-----------------------------------------------------------------------
// <copyright file="LeapYear.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
using System;

    /// <summary>
    /// To find leap year
    /// </summary>
    public class LeapYear
    {
        /// <summary>
        /// define the entry point of the application
        /// </summary>
        public static void Yearleap()
        {
            Console.WriteLine("enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            UtilityClass.Year(year);
        }
    }
}
