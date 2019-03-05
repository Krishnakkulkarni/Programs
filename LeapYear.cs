//-----------------------------------------------------------------------
// <copyright file="LeapYear.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
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
            try
            {
                Console.WriteLine("enter the year");
                int year = Convert.ToInt32(Console.ReadLine());
                UtilityClass.Year(year);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
