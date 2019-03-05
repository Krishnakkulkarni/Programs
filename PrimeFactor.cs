//-----------------------------------------------------------------------
// <copyright file="PrimeFactor.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
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
        /// <param name="args">The args.</param>
        public static void Primefactor()
        {
            try
            {
                Console.WriteLine("enter the number");
                int number = Convert.ToInt32(Console.ReadLine());
                UtilityClass.Primefactor(number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}