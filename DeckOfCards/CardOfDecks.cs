//-----------------------------------------------------------------------
// <copyright file="CardOfDecks.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.DeckOfCards
{
    using System;

    /// <summary>
    /// Class for Deck Of cards
    /// </summary>
    public class CardOfDecks
    {
        /// <summary>
        /// Decks this instance.
        /// </summary>
        public void Deck()
        {
            try
            {
                //// Storing the card inside the array
                string[,] playercard = Cards.CardDistribute();
                Console.WriteLine("Player1 \t Player2 \t Player3 \t Player4");
                Console.WriteLine();
                int count1 = 0;
                int count2 = 0;

                //// Loops over to store 9 cards for each palyer
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        //// Prints the card
                        Console.Write(playercard[count1, count2] + " \t ");
                        count2++;
                        if (count2 == 9)
                        {
                            count2 = 0;
                            count1++;
                        }
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception expception)
            {
                Console.WriteLine(expception.Message);
            }
        }
    }
}