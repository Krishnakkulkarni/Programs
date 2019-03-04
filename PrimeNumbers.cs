//-----------------------------------------------------------------------
// <copyright file="PrimeNumbers.cs" company="Bridgelabz">
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
    /// To check the Prime number 
    /// </summary>
    public class PrimeNumbers
    {
        /// <summary>
        /// Method to take input and call for Main method
        /// </summary>
        public static void NumbersOfPrime()
        {
            Console.WriteLine("enter the number to check prime");
            int number = Convert.ToInt32(Console.ReadLine());
            Utilityclass.Prime(number);
        }
    }
}
