//-----------------------------------------------------------------------
// <copyright file="MergeSort.cs" company="Bridgelabz">
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
    /// To sort the elements using MergeSort
    /// </summary>
    public class MergeSort
    {
        /// <summary>
        /// Method to take input and call from Main method
        /// </summary>
        public static void Sorting()
        {
            try
            {
                int length = Utilityclass.Input("enter number of elements: ");
                if (length > 0)
                {
                    int[] intArray = new int[length];
                    Utilityclass.ReadIntArray(intArray, length); //// reads elements of array

                    Mergesort(intArray);

                    Console.WriteLine("Elements sorted through Merge Sort Algorithm:");
                    for (int i = 0; i < intArray.Length; i++)
                    {
                        Console.WriteLine(intArray[i] + " ");
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("number should be greater than zero.. try again");
                }
            }
            catch (NumberFormatException e)
            {
                Console.WriteLine("only numeric input allowed.. try again");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// purpose dividing array into sub-arrays namely left array and right array through recursion
        /// </summary>
        /// <param name="a">parameter a array</param>
        public static void Mergesort(int[] a)
        {
            int n = a.Length;
            //// base condition to return from recursion
            if (n < 2) 
            {
                return;
            }
            else
            {
                int mid = n / 2;
                int[] leftA = new int[mid];
                int[] rightA = new int[n - mid];

                for (int i = 0; i < mid; i++)
                {
                    leftA[i] = a[i];
                }

                for (int i = mid; i < n; i++)
                {
                    rightA[i - mid] = a[i];
                }

                Mergesort(leftA);
                Mergesort(rightA); //// then dividing the right sub-array by recursive call
                MergeArray(leftA, rightA, a); //// sorting and merging left and right sub-array
            }
        }

        /// <summary>
        /// purpose merging the elements after sorting the elements
        /// </summary>
        /// <param name="leftArray">parameter leftArray</param>
        /// <param name="rightArray">param rightArray</param>
        /// <param name="array">param array</param>
        public static void MergeArray(int[] leftArray, int[] rightArray, int[] array)
        {
            int left = leftArray.Length, right = rightArray.Length;
            int i = 0, j = 0, k = 0;
            //// comparing elements of left array and right sub-array
            //// and inserting those into original array
            while (i < left && j < right) 
            {                               
                if (leftArray[i] < rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }

                k++;
            }

            while (i < left)
            {
                array[k] = leftArray[i];
                i++;

                k++;
            }

            while (j < right)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}