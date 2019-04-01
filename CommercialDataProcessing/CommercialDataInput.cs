﻿//-----------------------------------------------------------------------
// <copyright file="CommercialDataInput.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    using System;

    /// <summary>
    /// Class for Commercial Data Input
    /// </summary>
    public class CommercialDataInput
    {
        /// <summary>
        /// Takes the user input.
        /// </summary>
        /// <param name="choosedOption">The choosed option.</param>
        public static void TakeUserInput(int choosedOption)
        {
            StockAccount stockAccount = new StockAccount();
            int numberOfShares = 0;
            double priceOfShare = 0;
            string symbol = string.Empty;
            string datetime = string.Empty;

            if (choosedOption == 1)
            {
                while (true)
                {
                    Console.WriteLine("Enter the Number of shares");
                    string stringNumberOfShares = Console.ReadLine();

                    if (Utility.IsNumber(stringNumberOfShares) == false)
                    {
                        Console.WriteLine("Invalid input");
                        continue;
                    }

                    numberOfShares = Convert.ToInt32(stringNumberOfShares);
                    break;
                }

                while (true)
                {
                    Console.WriteLine("Enter the Price Of Share");
                    string stringpriceOfShare = Console.ReadLine();

                    if (Utility.IsNumber(stringpriceOfShare) == false)
                    {
                        Console.WriteLine("Invalid input");
                        continue;
                    }

                    priceOfShare = Convert.ToInt32(stringpriceOfShare);
                    break;
                }

                while (true)
                {
                    Console.WriteLine("Enter the Stock Symbol");
                    string stringSymbol = Console.ReadLine();

                    if (Utility.CheckString(stringSymbol))
                    {
                        Console.WriteLine("Stock Symbol cant be empty");
                        continue;
                    }

                    if (Utility.ContainsCharacter(stringSymbol))
                    {
                        Console.WriteLine("No characters allowed");
                        continue;
                    }

                    symbol = stringSymbol;
                    break;
                }

                stockAccount.Buy(numberOfShares, priceOfShare, symbol);
            }

            if (choosedOption == 2)
            {
                while (true)
                {
                    Console.WriteLine("Enter the Stock Symbol of the share you want to sell");
                    string stringSymbol = Console.ReadLine();

                    if (Utility.CheckString(stringSymbol))
                    {
                        Console.WriteLine("Stock Symbol cant be empty");
                        continue;
                    }

                    symbol = stringSymbol;

                    stockAccount.Sell(symbol);
                    break;
                }
            }
        }
    }
}