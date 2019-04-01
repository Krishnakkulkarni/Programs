//-----------------------------------------------------------------------
// <copyright file="MainClass.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
    using Implementations;
    using ObjectOrientedPrograms.AddressBook;
    using ObjectOrientedPrograms.CommercialDataProcessing;
    using ObjectOrientedPrograms.DeckOfCards;
    using ObjectOrientedPrograms.DeckOfQueue;
    using ObjectOrientedPrograms.RegularExpression;
    using ObjectOrientedPrograms.Stock;

    /// <summary>
    /// Class to Print all Programs
    /// </summary>
    public class MainClass
    {
            /// <summary>
            /// Defines the entry point of Main Class
            /// </summary>
            /// <param name="args">The arguments.</param>
            public static void Main(string[] args)
            {
                try
                {
                    int option = 1;
                    do
                    {
                        Console.WriteLine("1. Inventory data");
                        Console.WriteLine("2. Regular expression");
                        Console.WriteLine("3. Stock Report");
                        Console.WriteLine("4. Inverntory manager");
                        Console.WriteLine("5. Decks OF Cards");
                        Console.WriteLine("6. Decks OF Cards in Queue");
                        Console.WriteLine("7. AddressBook");
                        Console.WriteLine("8. Commercial Data Processing");
                        Console.WriteLine("9. Delegats");
                        Console.WriteLine("Choose your option from above");

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

                            case 7:
                                Address address = new Address();
                                address.BookDetails();
                                break;

                            case 8:
                                Commercial commercial = new Commercial();
                                commercial.InitialiseShares();
                                break;

                        case 9:
                            DelegateEx.Delegatemain();
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
