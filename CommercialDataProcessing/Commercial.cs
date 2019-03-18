//-----------------------------------------------------------------------
// <copyright file="Commercial.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    using System;

    /// <summary>
    /// StartCommercial Class
    /// </summary>
    public class Commercial
    {
        /// <summary>
        /// Starts  the shares.
        /// </summary>
        public void InitialiseShares()
        {
            StockAccount stockAccount = new StockAccount();
            while (true)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1. To buy Share");
                Console.WriteLine("2. To Sell a Share");
                Console.WriteLine("3. To view Existing Shares");
                Console.WriteLine("4. To View Stock Symobol Purchased");

                string stringOption = Console.ReadLine();

                if (Utility.IsNumber(stringOption) == false)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                int option = Convert.ToInt32(stringOption);

                switch (option)
                {
                    case 1:
                        {
                            CommercialDataInput.TakeUserInput(option);
                            break;
                        }

                    case 2:
                        {
                            CommercialDataInput.TakeUserInput(option);
                            break;
                        }

                    case 3:
                        {
                            stockAccount.PrintReport();
                            break;
                        }

                    case 4:
                        {
                            StockAccount.PrintSymbols();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid Input");
                            break;
                        }
                }
            }
        }
    }
}
