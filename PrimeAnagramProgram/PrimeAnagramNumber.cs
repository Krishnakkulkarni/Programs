//-----------------------------------------------------------------------
// <copyright file="PrimeAnagramNumber.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DataStructurePrograms.PrimeAnagramNumber
{
    using System;

    /// <summary>
    /// Class for finding prime numbers are anagram or not 
    /// </summary>
    public class PrimeAnagramNumber
    {
        /// <summary>
        /// Method for finding prime numbers are anagram or not 
        /// </summary>
        public static void PrimeNumbersAnagramNumbers()
        {
            try
            {
                //// Creating a utility object
                UtilityClass u = new UtilityClass();

                //// Initializing it to zero
                int i = 0, j, count, n;

                //// Defining the array
                int[,] primeArray = new int[10, 50];

                //// Defining the array
                int[,] anagramNumbers = new int[10, 50];

                //// Loops over to find the array
                for (i = 1; i < 10; i++)
                {
                    primeArray[i, 0] = primeArray[i - 1, 0] + 100;
                    anagramNumbers[i, 0] = anagramNumbers[i - 1, 0] + 100;
                }

                //// Loops over for storing prime numbers in range
                for (i = 0; i < 10; i++)
                {
                    count = 0;

                    //// Loops over for finding prime number in that range
                    for (j = 1; j < 100; j++)
                    {
                        //// Checks for prime Numbers
                        if (UtilityClass.IsPrimeNumber(primeArray[i, 0] + j))
                        {
                            count++;

                            //// Storing the prime numbers in tha array
                            primeArray[i, count] = primeArray[i, 0] + j;
                        }
                    }
                }

                //// Prints the prime numbers in that range
                Console.WriteLine("The prime numbers are: ");
                for (i = 0; i < 10; i++)
                {
                    Console.WriteLine("{0} - {1}: ", primeArray[i, 0], primeArray[i, 0] + 100);
                    for (j = 1; primeArray[i, j] != 0; j++)
                    {
                        Console.Write(primeArray[i, j] + " ");
                    }

                    Console.WriteLine();
                }

                //// Loops over to check that the prime numbers are anagram or not
                for (i = 0; i < 10; i++)
                {
                    count = 0;
                    for (j = 1; primeArray[i, j] != 0; j++)
                    {
                        for (n = j + 1; primeArray[i, n] != 0; n++)
                        {
                            //// Checks if prime numbers are anagram or not
                            if (UtilityClass.Anagram(Convert.ToString(primeArray[i, j]), Convert.ToString(primeArray[i, n])))
                            {
                                count++;
                                anagramNumbers[i, count++] = primeArray[i, j];
                                anagramNumbers[i, count] = primeArray[i, n];
                            }
                        }
                    }
                }

                //// Prints the prime numbers
                Console.WriteLine("The prime numbers that are anagrams are: ");
                for (i = 0; i < 10; i++)
                {
                    Console.WriteLine("{0} - {1}", anagramNumbers[i, 0], anagramNumbers[i, 0] + 100);
                    for (j = 1; anagramNumbers[i, j] != 0; j++)
                    {
                        Console.Write(anagramNumbers[i, j] + " ");
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}