//-----------------------------------------------------------------------
// <copyright file="MainClass.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
    using ObjectOrientedPrograms.DeckOfCards;
    using ObjectOrientedPrograms.DeckOfQueue;
    using ObjectOrientedPrograms.InventoryDetails;
    using ObjectOrientedPrograms.InventoryManager;
    using ObjectOrientedPrograms.RegularExpression;
    using ObjectOrientedPrograms.Stock;

    /// <summary>
    /// Class to Print all Programs
    /// </summary>
    public class MainClass
    {
            /// <summary>
            /// Defines the entry point of the application.
            /// </summary>
            /// <param name="args">The arguments.</param>
            public static void Main(string[] args)
            {
                try
                {
                    int option = 1;
                    do
                    {
                        Console.WriteLine("Enter 1 for Inventory data");
                        Console.WriteLine("Enter 2 for regular expression");
                        Console.WriteLine("Enter 3 for Stock Report");
                        Console.WriteLine("Enter 4 for Inverntory manager");
                        Console.WriteLine("Enter 5 for Decks OF Cards");
                        Console.WriteLine("Enter 6 for Decks OF Cards in Queue");
                        Console.WriteLine("Enter yor choice!!!");

                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                            InventoryDetails.Inventory inventor = new InventoryDetails.Inventory();
                                inventor.InventoryData();
                                break;

                            case 2:
                                RegexExpression regex = new RegexExpression();
                                regex.ReadData();
                                break;

                            case 3:
                                StockReport stock = new StockReport();
                                stock.StockData();
                                break;

                            case 4:
                                InventoryManager.InventoryManager inventoryManager = new InventoryManager.InventoryManager();
                                inventoryManager.Manager();
                                break;

                            case 5:
                            CardOfDecks cardOfDecks = new CardOfDecks();
                            cardOfDecks.Deck();
                                break;

                            case 6:
                                DeckQueue deckOfCards = new DeckQueue();
                                deckOfCards.CardInQueue();
                                break;

                        default:
                                Console.WriteLine("Select correct choice");
                                break;
                        }

                    Console.WriteLine("Press 1 to continue or 0 to discontinue");
                    option = Convert.ToInt32(Console.ReadLine());
                }
                while (option != 0);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
