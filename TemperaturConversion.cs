//-----------------------------------------------------------------------
// <copyright file="TemperaturConversion.cs" company="Bridgelabz">
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
    /// Temperature conversion from celsius and fahrenheit
    /// </summary>
    public class TemperaturConversion
    {
        /// <summary>
        /// Method to take input and call for Main method
        /// </summary>
        public static void ConversionTemperatur()
        {
            try
            {
                Console.WriteLine("Enter Tempareture in Celsius or Fahrenheit");
                int tempareture = Convert.ToInt32(Console.ReadLine());
                char unit = Convert.ToChar(Console.ReadLine());
                Utilityclass.TemparetureConversion(tempareture, unit);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
