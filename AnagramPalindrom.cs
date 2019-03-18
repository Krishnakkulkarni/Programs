//-----------------------------------------------------------------------
// <copyright file="AnagramPalindrom.cs" company="Bridgelabz">
//     Company @ 2018 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace AlgorithmPrograms
{
     using System;
    using System.Collections;

    /// <summary>
    /// prints Prime Number that are palindrome
    /// </summary>
    public class AnagramPalindrom
    {
        /// <summary>
        /// Method to read take the input from the user. 
        /// </summary>
        public static void Palindrom()
        {
            try
            {
                //// Create arraylist for storing prime numbers
                ArrayList arrayList = new ArrayList();

                //// Generates prime numbers from 0-1000
                Console.WriteLine("Prime Numbers from 0-1000");
                for (int i = 0; i <= 1000; i++)
                {
                    if (Utilityclass.IsPrime(i))
                    {
                        //// Adds the prime numbers into the arrayList
                        arrayList.Add(i);
                    }
                }

                //// Displays prime number
                foreach (int x in arrayList)
                {
                    Console.Write(x + " ");
                }

                Console.WriteLine();

                //// Lopps over prime numbers to find it is palindrome or not
                for (int j = 0; j < arrayList.Count; j++)
                {
                    int reminder;
                    int sum = 0;
                    int number = Convert.ToInt32(arrayList[j]);
                    int original = number;

                    //// Number between 0 and 9 is the same
                    if (number >= 2 && number <= 9)
                    {
                        sum = number;
                    }
                    else
                    {
                        //// reverses the original number
                        while (number >= 1)
                        {
                            reminder = number % 10;
                            sum = (sum * 10) + reminder;
                            number = number / 10;
                        }
                    }

                    //// checks if reverse is equal to orginal number
                    if (sum == original)
                    {
                        Console.WriteLine(original);
                    }
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Method for finding the prime Numbers are Anagram
        /// </summary>
        public void AnagramPrime()
        {
            try
            {
                //// Create arraylist for storing prime numbers
                ArrayList arrayList = new ArrayList();
                Console.WriteLine("Prime Numbers from 0-1000");

                for (int i = 0; i <= 1000; i++)
                {
                    if (Utilityclass.IsPrime(i))
                    {
                        arrayList.Add(i);
                    }
                }

                Console.WriteLine();

                //// Looping over the arraylist to find out which numbers are anagram
                Console.WriteLine("Printing the Prime Numbers that are Anagram");
                for (int j = 0; j < arrayList.Count; j++)
                {
                    //// Storing numbers in string
                    string num1 = arrayList[j] + string.Empty;

                    //// convert the string to array
                    char[] numInArray1 = num1.ToCharArray();

                    //// Sorting the array using Array.Sort
                    Array.Sort(numInArray1);

                    //// Storing back the array in new String object
                    string orginal1 = new string(numInArray1);

                    //// Loops over the arraylist for comparing with next number or element
                    for (int k = j + 1; k < arrayList.Count; k++)
                    {
                        //// Storing numbers in string
                        string num2 = arrayList[k] + string.Empty;

                        //// convert the string to array
                        char[] numInArray2 = num2.ToCharArray();

                        //// Sorting the array using Array.Sort
                        Array.Sort(numInArray2);

                        //// Storing back the array in new String object
                        string orginal2 = new string(numInArray2);

                        //// Checks if two strings are equal
                        if (orginal1.Equals(orginal2))
                        {
                            Console.Write(num1 + " " + num2);
                            Console.WriteLine();
                        }
                    }
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}