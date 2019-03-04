//-----------------------------------------------------------------------
// <copyright file="InsertionSort.cs" company="Bridgelabz">
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
    /// Sort the numbers using InsertionSort
    /// </summary>
    public class InsertionSort
    {
        /// <summary>
        /// Method to take input and call for Main method
        /// </summary>
        public static void CallForSorting()
        {
            try
            {
                Console.WriteLine("Enter the number");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the numbers to be sorted");
                int[] array = new int[number];
                for (int i = 0; i < number; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                Utilityclass.Sort(array);
                Utilityclass.PrintArray(array);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}