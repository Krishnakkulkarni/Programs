//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DataStructures
{
    using System;
    using DataStructurePrograms.CalendarQueue;
    using DataStructurePrograms.CalendarStack;
    using OrderedList.Balancedparaentises;
    using OrderedList.Banking;
    using OrderedList.CalendarProgram;
    using OrderedList.PalindromeChecker;
   
    /// <summary>
    /// Entry point of the Main class
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Defines the entry point of the application
        /// </summary>
        /// <exception cref="Exception">handles and throws Exception</exception>
        public static void Main()
        {
            try
            {
                int option = -1; //// option for choosing a number from Utility.
                bool flag = true; //// flag for keep looping untill a valid option from the existing Utility Class
                while (flag)
                {
                    Console.WriteLine(" \n Select the program from below .Enter 0 to exit");
                    Console.WriteLine(" 1. Unordered LinkedList \n 2. Ordered LinkedList \n 3. Balanced Parentheses \n 4. Banking cash Counter");
                    Console.WriteLine(" 5. Palindrome Checker \n 6. CalendarQueue \n 7. CalendarStack");
                    Console.WriteLine("Enter the number you want");
                    try
                    {
                        option = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid Command");
                        continue;
                    }

                    switch (option)
                    {
                        case 0:
                            {
                                flag = false;
                                break;
                            }

                        case 1:
                            {
                                OrderedList.Unordered.LinkedList_UnOrdered.UnOrderedList();
                                break;
                            }

                        case 2:
                            {
                                OrderedList.List.Ordered();
                                break;
                            }

                        case 3:
                            {
                                Balanced.CheckParentheses();
                                break;
                            }

                        case 4:
                            {
                                CashCounter.Counter();
                                break;
                            }

                        case 5:
                            {
                                PalindromeChecker.CheckPalindrome();
                                break;
                            }

                        case 6:
                            {
                                CalendarInput.CalendarStart();
                                break;
                            }

                        case 7:
                            {
                                InputCalendar.StartCalendar();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid Option");
                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
