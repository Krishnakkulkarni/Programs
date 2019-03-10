
namespace DataStructurePrograms.PrimeAnagramnumberStack
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /// <summary>
    /// PrimeAnagramStack Class
    /// </summary>
    public class PrimeAnagramStack
    {
        /// <summary>
        /// Prime numbers that are anagram numbers.
        /// </summary>
        public static void PrimeAndAnagramNumbers()
        {
            try
            {
                //// Creating array for storing generated prime numbers
                int[] array1 = new int[168];
                int j = 0;

                //// Looping over to find the prime number
                for (int i = 2; i <= 1000; i++)
                {
                    //// Checks for number is prime or not
                    if (Utility.IsPrimeNumber(i))
                    {
                        array1[j] = i;
                        j++;
                    }
                }

                //// Displaying the prime numbers
                foreach (int array2 in array1)
                {
                    Console.Write(array2 + " ");
                }

                Console.WriteLine();

                //// Creating the linked list stack 
                LinkedListStack linkedListStack = new LinkedListStack();
                Console.WriteLine("The prime numbers which are anagram : ");

                //// Loops over the string
                for (int k = 0; k < array1.Length - 1; k++)
                {
                    for (int l = k + 1; l < array1.Length; l++)
                    {
                        string string1 = array1[k].ToString();
                        string string2 = array1[l].ToString();

                        //// Checks for the two string is anagram or not
                        if (Utility.Anagram(string1, string2))
                        {
                            //// Pushes the string to stack
                            linkedListStack.Push(string1);

                            //// Pushes the string to stack
                            linkedListStack.Push(string2);
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
