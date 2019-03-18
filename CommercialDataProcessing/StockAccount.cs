//-----------------------------------------------------------------------
// <copyright file="StockAccount.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// StockAccount Class
    /// </summary>
    /// <seealso cref="OOP.Commercial_Data_Processing.IStockAccount" />
    public class StockAccount : IStockAccount
    {
        /// <summary>
        /// Company shares are in Linked List
        /// </summary>
       private readonly LinkedList<CompanyShares> companySharesList = new LinkedList<CompanyShares>();

        /// <summary>
        /// Method to print symbols
        /// </summary>
        public static void PrintSymbols()
        {
            Stack symbolStack = ReadWritefile.ReadStockSymbols();

            Console.WriteLine(" Your Currently purchased Symbols are ");

            while (!symbolStack.IsEmpty())
            {
                Console.Write(symbolStack.Pop() + " ");
            }
        }

        /// <summary>
        /// Buys the specified number of shares.
        /// </summary>
        /// <param name="numberOfShares">number of shares</param>
        /// <param name="priceofshares">price of shares</param>
        /// <param name="symbol">symbol</param>
        public void Buy(long numbeofshares, double priceofshares, string symbol)
        {
            List<CompanyShares> companySharesList = ReadWritefile.ReadFromFile();

            foreach (CompanyShares shares in companySharesList)
            {
                if (shares.Symbol.Equals(symbol))
                {
                    Console.WriteLine("You have already bought this share with symbol " + symbol);
                    return;
                }
            }

            Console.WriteLine(symbol + " bought ");

            string dateTime = DateTime.Now.ToString();
            CompanyShares companyShares = new CompanyShares(numbeofshares, priceofshares, symbol, dateTime);
            companySharesList.Add(companyShares);

            ReadWritefile.WriteToFile(companySharesList);
        }

        /// <summary>
        /// Prints the report.
        /// </summary>
        public void PrintReport()
        {
            double totalValueOfAllStock = 0;
            List<CompanyShares> companySharesList = ReadWritefile.ReadFromFile();

            foreach (CompanyShares cs in companySharesList)
            {
                Console.WriteLine("StockName : " + cs.Symbol + "\nNumber of Shares: " + cs.Numberofshares + "\nPrice Of each share: " + cs.Priceofshares + "\nPurchased Date and Time : " + cs.DateTime);
                Console.WriteLine("Total Value Of Stock " + cs.Symbol + ": " + (cs.Numberofshares * cs.Priceofshares));
                Console.WriteLine("--------------------------------");

                totalValueOfAllStock = totalValueOfAllStock + (cs.Numberofshares * cs.Priceofshares);
            }

            Console.WriteLine("Total value Of all Stocks = " + totalValueOfAllStock);
        }

        /// <summary>
        /// Saves the specified file name.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <exception cref="NotImplementedException">Handles and throws Exception</exception>
        public void Save(string fileName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sells the specified symbol.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public void Sell(string symbol)
        {
            List<CompanyShares> companySharesList = ReadWritefile.ReadFromFile();
            foreach (CompanyShares companyShares in companySharesList)
            {
                if (companyShares.Symbol.Equals(symbol))
                {
                    companySharesList.Remove(companyShares);
                    Console.WriteLine(symbol + " Selled ");
                    ReadWritefile.WriteToFile(companySharesList);
                    return;
                }
            }

            Console.WriteLine("stock with Symbol " + symbol + "does not exist");
        }
    }
}
