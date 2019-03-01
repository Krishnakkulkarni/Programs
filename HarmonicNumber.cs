//-----------------------------------------------------------------------
// <copyright file="HarmonicNumber.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
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
            Console.WriteLine("enter the number");
            double number = Convert.ToDouble(Console.ReadLine());
            UtilityClass.Harmonic(number);
        }
    }
}