//-----------------------------------------------------------------------
// <copyright file="AnagramPalindrom.cs" company="Bridgelabz">
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
    /// prints Prime Number that are palindrome
    /// </summary>
    public class AnagramPalindrom
    {
        /// <summary>
        /// Method to read take the input from the user. 
        /// </summary>
        public static void PalindromAnagram()
        {
            try
            {
                Console.WriteLine("enter the number to check prime");
                int number = Convert.ToInt32(Console.ReadLine());
                Utilityclass.PrintPrimePalindrome(number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
