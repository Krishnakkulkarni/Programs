//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;

    /// <summary>
    /// To Print all programs from main class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Define the entry point of the Main method
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
            int choose;
            string yes;
            do
            {
                Console.WriteLine(" 1.AnagramDetection \n 2.PrimeNumbers \n 3.AnagramPalindrom \n 4.SearchSort \n 5.FindYourOwnNumber \n 6.SearchWordFromFile ");
                Console.WriteLine(" 7.InsertionSort \n 8.BubbleSort \n 9.MergeSort \n 10.VendingMachine \n 11.DayOfWeek \n 12.TemperaturConversion ");
                Console.WriteLine(" 13.MonthlyPayments \n 14.SquareRoot \n 15.ConvertToBinary \n 16.BinaryToSwapNibbles \n");
                Console.WriteLine("enter the your choose");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Anagram.AnagramDetection();
                        break;
                    case 2:
                        PrimeNumbers.NumbersOfPrime();
                        break;
                    case 3:
                        AnagramPalindrom.PalindromAnagram();
                        break;
                    case 4:
                            SearchSort.Searchsort();
                        break;
                    case 5:
                        FindingNumber.FindNumber();
                        break;
                    case 6:
                        WordSearchFromFile.WordSearchfromFile();
                        break;
                    case 7:
                        InsertionSort.CallForSorting();
                        break;
                    case 8:
                        BubbleSort.Sorting();
                        break;
                    case 9:
                        MergeSort.Sorting();
                        break;
                    case 10:
                        VendingMachine.CalculateMinimumNote();
                        break;
                    case 11:
                        DayOfWeek.FindTheDay();
                        break;
                    case 12:
                        TemperaturConversion.ConversionTemperatur();
                        break;
                    case 13:
                        MonthlyPayment.PaymentMonthly();
                        break;
                    case 14:
                        SquareRoot.Square();
                        break;
                    case 15:
                        ToBinary.ConvertToBinary();
                        break;
                    case 16:
                        SwapNibbles.BinaryToSwapNibbles();
                        break;
                        default:
                        Console.WriteLine("enter the valid choose");
                        break;
                }

                    Console.WriteLine("do you want continue");
                    yes = Console.ReadLine();
                }
                while (choose != 0 && yes != "no");
            }
            catch (Exception e)
            {
               Console.WriteLine(e.Message);
            }
        }
    }
}
