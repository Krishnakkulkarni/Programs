//-----------------------------------------------------------------------
// <copyright file="PrimeAnagramQueue.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DataStructurePrograms.PrimeAnagramNumberQueue
{
    using System;

    /// <summary>
    /// PrimeAnagramQueue class
    /// </summary>
    public class PrimeAnagramQueue
    {
        /// <summary>
        /// Primes the and anagram numbers.
        /// </summary>
        public static void PrimeAnagramNumbers()
        {
            try
            {
                //// array to store the prime numbers
                int[] array1 = new int[168];
                int j = 0;

                //// Loops over for finding prime numbers from 0 to 1000
                for (int i = 2; i <= 1000; i++)
                {
                    //// Checks for prime number
                    if (UtilityClass.IsPrimeNumber(i))
                    {
                        //// Adding prime numbers to array
                        array1[j] = i;
                        j++;
                    }
                }

                //// Loops over the array to print in reverse order
                foreach (int x in array1)
                {
                    Console.Write(x + " ");
                }

                Console.WriteLine();

                //// Creating Linked List Queue
                LinkedListQueue linkedListQueue = new LinkedListQueue();

                //// Displays for prime m=numbers
                Console.WriteLine("The prime numbers which are anagram are : ");
                for (int k = 0; k < array1.Length - 1; k++)
                {
                    for (int l = k + 1; l < array1.Length; l++)
                    {
                        string string1 = array1[k].ToString();
                        string string2 = array1[l].ToString();

                        //// Checks if 2 strings are anagram or not
                        if (UtilityClass.Anagram(string1, string2))
                        {
                            //// enqueue into the list
                            linkedListQueue.Enqueue(string1);

                            //// enqueue into the list
                            linkedListQueue.Enqueue(string2);
                            Console.WriteLine();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
