//-----------------------------------------------------------------------
// <copyright file="Anagram.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
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
/// To find Given strings are Anagram or not
/// </summary>
    public class Anagram
    {
        /// <summary>
        /// Method to take the input from user
        /// </summary>
        public static void AnagramDetection()
        {
            try
            {
                Console.WriteLine("Enter the First string");
                string word1 = Console.ReadLine();
                Console.WriteLine("Enter the second string");
                string word2 = Console.ReadLine();
                Utilityclass.Detection(word1, word2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
