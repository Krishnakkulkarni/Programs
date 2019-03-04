//-----------------------------------------------------------------------
// <copyright file="DayOfWeek.cs" company="Bridgelabz">
//     Company @ 2018 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

    /// <summary>
    /// To find Day in a week
    /// </summary>
    public class DayOfWeek
    {
        /// <summary>
        /// Method to take input and call for Main method
        /// </summary>
        public static void FindTheDay()
        {
            try
            {
                Console.WriteLine("Enter Day :");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Month :");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Year :");
                int year = Convert.ToInt32(Console.ReadLine());
              ////  Console.WriteLine(Utilityclass.DayOfWeek(day, month, year));
                Utilityclass.DayOfWeek(day, month, year);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
