//-----------------------------------------------------------------------
// <copyright file="BubbleSort.cs" company="Bridgelabz">
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
    /// Sort the elements using Bubble sort
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// Sorting the instance.
        /// </summary>
        public static void Sorting()
        {
            try
            {
                //// Accepting values for sorting integer number
                Console.WriteLine("Enter number of sorting elements ");
                int[] input = new int[Convert.ToInt32(Console.ReadLine())];
                Console.WriteLine("Enter the elements ");

                //// iteration to accept values depending size of array
                for (int i = 0; i < input.Length; i++)
                {
                    input[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Sorted elements are");
                //// Calling of sorting function 
                Utilityclass.BubbleSort(input);

                //// To Display sorted elements 
                for (int i = 0; i < input.Length; i++)
                {
                    Console.WriteLine(" " + input[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
