//-----------------------------------------------------------------------
// <copyright file="ReadWritefile.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// Class to read and write to file
    /// </summary>
    public class ReadWritefile
    {
        /// <summary>
        /// Method to read a file
        /// </summary>
        /// <returns>returns a list</returns>
        public static List<CompanyShares> ReadFromFile()
        {
            LinkedList<CompanyShares> companysharesLinkedList = new LinkedList<CompanyShares>();
            if (File.Exists(@"C:\Users\admin\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\CommercialDataProcessing\CompanyShares.json"))
            {
                string jsonData = File.ReadAllText(@"C:\Users\admin\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\CommercialDataProcessing\CompanyShares.json");
                List<CompanyShares> jsonObjectArray = JsonConvert.DeserializeObject<List<CompanyShares>>(jsonData);

                foreach (CompanyShares companyShares in jsonObjectArray)
                {
                    companysharesLinkedList.Add(companyShares);
                }

                return jsonObjectArray;
            }
            else
            {
                Console.WriteLine("File path not found");
                return new List<CompanyShares>();
            }
        }

        /// <summary>
        /// Method to Write to file
        /// </summary>
        /// <param name="companyShares">companyShares is a parameter</param>
        public static void WriteToFile(List<CompanyShares> companyShares)
        {
            string jsonData = JsonConvert.SerializeObject(companyShares);
            File.WriteAllText(@"C:\Users\admin\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\CommercialDataProcessing\CompanyShares.json", jsonData);
        }

        /// <summary>
        /// Method to read a Stock Symbols
        /// </summary>
        /// <returns>returns symbol Stack</returns>
        internal static Stack ReadStockSymbols()
        {
            Stack symbolStack = new Stack();
            symbolStack.StackInitialise(1000);
            List<CompanyShares> stocksList = ReadFromFile();

            foreach (CompanyShares companyShares in stocksList)
            {
                symbolStack.Push(companyShares.Symbol);
            }

            return symbolStack;
        }
    }

    /*
        /// <summary>
        /// Method to write a symbol stock
        /// </summary>
        /// <param name="symbolStack">return symbol Stack</param>
        public static void WriteSymbol(Stack symbolStack)
        {
            List<string> symbolList = new List<string>();
            while (!symbolStack.IsEmpty())
            {
                symbolList.Add(symbolStack.Pop());

            }
            string jsonData = JsonConvert.SerializeObject(symbolList);

            File.WriteAllText(@"C:\Users\admin\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\CommercialDataProcessing\SymbolPurchased.json", jsonData);
        }*/
}
