//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DataStructures
{
    using System;
    using DataStructurePrograms._2DArrayPrimeNumber;
    using DataStructurePrograms.BinaryProgram;
    using DataStructurePrograms.CalendarQueue;
    using DataStructurePrograms.CalendarStack;
    using DataStructurePrograms.OrderedList;
    using DataStructurePrograms.PrimeAnagramNumber;
    using DataStructurePrograms.PrimeAnagramNumberQueue;
    using DataStructurePrograms.PrimeAnagramnumberStack;
    using DataStructurePrograms.UnOrderedList;
    using OrderedList.Balancedparaentises;
    using OrderedList.Banking;
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
                    Console.WriteLine(" 1.  Unordered LinkedList \n 2.  Ordered LinkedList \n 3.  Balanced Parentheses \n 4.  Banking cash Counter");
                    Console.WriteLine(" 5.  Palindrome Checker \n 6.  HashingProgram \n 7.  Binary search tree \n 8.  Calendar \n 9.  CalendarQueue");
                    Console.WriteLine(" 10. CalendarStack \n 11. 2DArrayPrimeNumber \n 12. PrimeAnagramNumber \n 13. PrimeAnagramStack \n 14. PrimeAnagramQueue \n");
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
                                InputForUnordered.UnOrderedList();
                                break;
                            }

                        case 2:
                            {
                                InputForOrdered.OrderedLinkedList();
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

                        /*case 6:
                            {
                                HashingProgram.Hashing();
                                break;
                            }*/

                        case 7:
                            {
                                BinaryTreeInput.BinaryTree();
                                break;
                            }

                        case 8:
                            {
                                CalendarInput.CalendarStart();
                                break;
                            }

                        case 9:
                            {
                                CalendarInput.CalendarStart();
                                break;
                            }

                        case 10:
                            {
                                InputCalendar.StartCalendar();
                                break;
                            }

                        case 11:
                            {
                                _2DPrime._2DArray();
                                break;
                            }

                        case 12:
                            {
                                PrimeAnagramNumber.PrimeNumbersAnagramNumbers();
                                break;
                            }

                        case 13:
                            {
                                PrimeAnagramStack.PrimeAndAnagramNumbers();
                                break;
                            }

                        case 14:
                            {
                                PrimeAnagramQueue.PrimeAnagramNumbers();
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
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
