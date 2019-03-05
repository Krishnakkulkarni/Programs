//-----------------------------------------------------------------------
// <copyright file="PowerOfTwo.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
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
        /// To find the Power of two
        /// </summary>
        public static void TwoToThePower()
        {
            try
            {
                Console.WriteLine("enter the number");
                double number = Convert.ToDouble(Console.ReadLine());
                UtilityClass.PowerOftwo(number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}