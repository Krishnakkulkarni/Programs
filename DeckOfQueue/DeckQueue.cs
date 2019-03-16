//-----------------------------------------------------------------------
// <copyright file="DeckQueue.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.DeckOfQueue
{
    using System;
    using System.Collections.Generic;
    using ObjectOrientedPrograms.DeckOfCards;

    /// <summary>
    /// Class for Deck of Queue
    /// </summary>
    public class DeckQueue
    {
        /// <summary>
        /// Cards in queue.
        /// </summary>
        public void CardInQueue()
        {
            try
            {
                string[,] playercard = Cards.CardDistribute();

                //// Creating Queue for storing sorted array
                Queue<Queue<string>> sortedcard = Cards.CardSort(playercard);

                //// Stores the list of players in player name
                string[] playername = { "Player 1 ", "Player 2 ", "Player 3 ", "Player 4 " };
                int index = 0;

                //// Loops over till the sortedcart is not 0
                while (sortedcard.Count != 0)
                {
                    //// Performs dequeue operations
                    Queue<string> temp = sortedcard.Dequeue();
                    Console.Write(playername[index] + " ");

                    //// Till temp is not 0
                    while (temp.Count != 0)
                    {
                        Console.Write(temp.Dequeue() + " \t ");
                    }

                    Console.WriteLine();
                    index++;
                }
            }
            catch (Exception expception)
            {
                Console.WriteLine(expception.Message);
            }
        }
    }
}
