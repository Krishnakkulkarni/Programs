//-----------------------------------------------------------------------
// <copyright file="WindChill.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// To calculate the WindChill using formula
    /// </summary>
    public class WindChill
    {
        /// <summary>
        /// Method to take input and call from Main method
        /// </summary>
        public static void Wind()
        {
            try
            {
                Console.WriteLine("enter the temperature ");
                double t = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter the speed ");
                double v = Convert.ToDouble(Console.ReadLine());
                UtilityClass.Chill(t, v);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
