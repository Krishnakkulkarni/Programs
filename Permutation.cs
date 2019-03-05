//-----------------------------------------------------------------------
// <copyright file="Permutation.cs" company="Bridgelabz">
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
/// To Print all permutations
/// </summary>
    public class Permutation
    {
        /// <summary>
        /// Method to take input from the user
        /// </summary>
        public static void PermutationNumber()
        {
            try
            {
                Console.WriteLine("enter the String");
                string str = Console.ReadLine();
                int n = str.Length;
                UtilityClass.Permute(str, 0, n - 1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}