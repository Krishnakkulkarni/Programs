//-----------------------------------------------------------------------
// <copyright file="Cards.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.DeckOfCards
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class for Utility
    /// </summary>
    public class Cards
    {
        /// <summary>
        /// Cards the distribute.
        /// </summary>
        /// <returns>returns string</returns>
        public static string[,] CardDistribute()
        {
            string[,] playercard = new string[4, 9];
            try
            {
                ////creating string array 
                string[,] arrayelements = new string[4, 13];
                CardInsert(arrayelements);
                CardShuffle(arrayelements);
                ////creating the playcard string array

                //// Looping over the playcards
                for (int i = 0; i < playercard.GetLength(0); i++)
                {
                    for (int j = 0; j < playercard.GetLength(1); j++)
                    {
                        playercard[i, j] = arrayelements[i, j];
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            return playercard;
        }

        /// <summary>
        /// Cards the insert.
        /// </summary>
        /// <param name="arrayelements">The array elements.</param>
        public static void CardInsert(string[,] arrayelements)
        {
            try
            {
                //// creating string array of suits
                string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
                //// creating string array of ranks
                string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "King", "Queen", "Ace" };
                ////loooping the lengthof the suite
                for (int i = 0; i < arrayelements.GetLength(0); i++)
                {
                    for (int j = 0; j < arrayelements.GetLength(1); j++)
                    {
                        arrayelements[i, j] = suits[i] + " " + rank[j];
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Cards the shuffle.
        /// </summary>
        /// <param name="arrayelements">The array elements.</param>
        public static void CardShuffle(string[,] arrayelements)
        {
            try
            {
                //// creating the random object
                Random random = new Random();
                for (int i = 0; i < 52; i++)
                {
                    ////Generating randome numbers
                    int number1 = Convert.ToInt32(random.Next(4));
                    int number2 = Convert.ToInt32(random.Next(13));
                    int number3 = Convert.ToInt32(random.Next(4));
                    int number4 = Convert.ToInt32(random.Next(13));
                    Swap(arrayelements, number1, number2, number3, number4);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Swaps the specified array elements.
        /// </summary>
        /// <param name="arrayelements">The array elements.</param>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <param name="number3">The number3.</param>
        /// <param name="number4">The number4.</param>
        public static void Swap(string[,] arrayelements, int number1, int number2, int number3, int number4)
        {
            try
            {
                //// Swapping of strings
                string temp = arrayelements[number1, number2];
                arrayelements[number1, number2] = arrayelements[number3, number4];
                arrayelements[number3, number4] = temp;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Cards the sort.
        /// </summary>
        /// <param name="playercard">The player card.</param>
        /// <returns>RETURNS QUEUE</returns>
        public static Queue<Queue<string>> CardSort(string[,] playercard)
        {
            Queue<Queue<string>> sortedcard = new Queue<Queue<string>>();
            try
            {
                //// storing the ranks in the array
                string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
                int[] arrayelements = new int[9];
                int index = 0;

                //// Looping over to swap
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        //// Storing the playcards in the array
                        string[] temp = (playercard[i, j] + " ").Split(' ');

                        //// Looping over the cards
                        for (int k = 0; k < 13; k++)
                        {
                            if (temp[1].Equals(rank[k]))
                            {
                                arrayelements[index] = k;
                                index++;
                            }
                        }
                    }

                    Console.WriteLine();
                    index = 0;

                    //// Performing bubble sort
                    for (int k1 = 0; k1 < arrayelements.Length - 1; k1++)
                    {
                        for (int k2 = k1 + 1; k2 < arrayelements.Length; k2++)
                        {
                            if (arrayelements[k1] > arrayelements[k2])
                            {
                                int temp = arrayelements[k1];
                                arrayelements[k1] = arrayelements[k2];
                                arrayelements[k2] = temp;

                                string temp1 = playercard[i, k1];
                                playercard[i, k1] = playercard[i, k2];
                                playercard[i, k2] = temp1;
                            }
                        }
                    }
                }

                //// looping for enqueuing 
                for (int i = 0; i < playercard.GetLength(0); i++)
                {
                    Queue<string> temp = new Queue<string>();
                    for (int j = 0; j < playercard.GetLength(1); j++)
                    {
                        temp.Enqueue(playercard[i, j]);
                    }

                    sortedcard.Enqueue(temp);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            return sortedcard;
        }

        /// <summary>
        /// Determines whether the specified string1 is string.
        /// </summary>
        /// <param name="string1">The string1.</param>
        /// <returns>returns string</returns>
        public static string IsString(string string1)
        {
            try
            {
                int i = 0;
                //// returns the value of substring present in the string
                if (string1.Contains(" "))
                {
                    Console.WriteLine("Invalid input");
                }

                for (i = 0; i < 10; i++)
                {
                    //// converts the integer value to equivalent string format
                    if (string1.Contains(i.ToString()))
                    {
                        Console.WriteLine("you have entered the wrong input");
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            return string1;
        }
    }
}
