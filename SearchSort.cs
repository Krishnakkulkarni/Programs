//-----------------------------------------------------------------------
// <copyright file="SearchSort.cs" company="Bridgelabz">
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
    /// To search and Sort the elements and present elements in sorted list
    /// </summary>
    public class SearchSort
    {
        /// <summary>
        /// Method to take input and call from Main method
        /// </summary>
        public static void Searchsort()
        {
            try
            {
                //// Accepting values for Binary search for integer
                Console.WriteLine("Enter the size for Binary Search : ");
                int[] element = new int[Convert.ToInt32(Console.ReadLine())];
                Console.WriteLine("Enter numeric array elements: ");
                //// iteration to accept values depending size of array
                for (int i = 0; i < element.Length; i++)
                {
                    element[i] = Convert.ToInt32(Console.ReadLine());
                }

                //// Accepting value to be search
                Console.WriteLine("Enter element to be search : ");
                int find = Convert.ToInt32(Console.ReadLine());
                //// Calling of Binary search for integer function 
                int f = Utilityclass.BinarySearch(element, find);
                //// Check value will found or not*/
                if (f > 0)
                {
                    Console.WriteLine("Element is found at index " + f);
                }
                else
                {
                    Console.WriteLine("Element not found");
                }

                //// Accepting values for Binary search for string
                Console.WriteLine("Enter the size for Binary search : ");
                string[] arr = new string[Convert.ToInt32(Console.ReadLine())];
                Console.WriteLine("Enter Strings : ");
                //// iteration to accept values depending size of array
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Console.ReadLine();
                }

                //// Accepting value to be search
                Console.WriteLine("Enter String to be search: ");
                string s = Console.ReadLine();
                //// Calling of Binary search for integer function 
                int result = Utilityclass.BinarySearch(arr, s);
                //// Check value will found or not
                if (result > 0)
                {
                    Console.WriteLine("Element is found at index " + f);
                }
                else
                {
                    Console.WriteLine("Element not found");
                }

                //// Accepting values for sorting integer number
                Console.WriteLine("Enter size of sorting elements : ");
                int[] value = new int[Convert.ToInt32(Console.ReadLine())];

                Console.WriteLine("Enter numeric elements : ");
                //// iteration to accept values depending size of array
                for (int i = 0; i < arr.Length; i++)
                {
                    value[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Sorted elements:");
                //// Calling of sorting function for integer
                Utilityclass.InsertionSort(value);
                Utilityclass.Bubblesort(value);
                //// Display sorted elements 
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(" " + arr[i]);
                }

                //// Accepting values for sorting string
                Console.WriteLine("Enter the size of sorting elements : ");
                int noOfValue = Convert.ToInt32(Console.ReadLine());
                string[] values = new string[noOfValue];
                Console.WriteLine("Enter String elements: ");
                //// iteration to accept values depending size of array 
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = Console.ReadLine();
                }

                //// Calling of sorting function for string
                Utilityclass.Bubblesort(values);
                Utilityclass.InsertionSort(values);
                Console.WriteLine("Sorted Elements :");
                //// Display sorted elements 
                for (int i = 0; i < values.Length; i++)
                {
                    Console.WriteLine(values[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}