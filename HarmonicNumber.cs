//-----------------------------------------------------------------------
// <copyright file="HarmonicNumber.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
 using System;

    /// <summary>
    /// To find a harmonic number
    /// </summary>
    public class HarmonicNumber
    { 
     /// <summary>
     /// define the entry point of the application
     /// </summary>
        public static void Harmonicnumber()
        {
            try
            {
                Console.WriteLine("enter the number");
                double number = Convert.ToDouble(Console.ReadLine());
                UtilityClass.Harmonic(number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}