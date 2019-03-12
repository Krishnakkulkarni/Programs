//-----------------------------------------------------------------------
// <copyright file="PalindromeChecker.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace OrderedList.PalindromeChecker
{
    using System;
    using DataStructurePrograms;

    /// <summary>
    /// Input for palindrome
    /// </summary>
    public class PalindromeChecker
    {
        /// <summary>
        /// Checks the palindrome.
        /// </summary>
        public static void CheckPalindrome()
        {
            string userString = string.Empty;
            try
            {
                Dequenode<char> deque = new Dequenode<char>();

                bool flag = true; //// keeps asking for a string (NO EMPTY STRING ALLOWED)
                while (flag)
                {
                    Console.WriteLine("Enter the String");
                    userString = Console.ReadLine();

                    if (UtilityClass.CheckString(userString))
                    {
                        Console.WriteLine("Empty string not allowed");
                        continue;
                    }

                    flag = false;
                }

                //// adding elements to rear
                for (int i = 0; i < userString.Length; i++)
                {
                    char c = userString[i];
                    deque.Addrear(c);
                }

                ////loop till size of queue and comparing the letters at front and rear of the queue
                while (deque.Size() > 1)
                {
                    if (deque.RemoveFront() != deque.RemoveRear())
                    {
                        Console.WriteLine("Given String is not Palindrome");
                        return;
                    }
                }

                Console.WriteLine("Given String is a Palindrome");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}