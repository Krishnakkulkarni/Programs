//-----------------------------------------------------------------------
// <copyright file="StockReport.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.Stock
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// Class for stock report
    /// </summary>
    public class StockReport
    {
        /// <summary>
        /// Stocks the data.
        /// </summary>
        public void StockData()
        {
            try
            {
                Constants constants = new Constants();

                //// Reading the file
                using (StreamReader streamReader = File.OpenText(constants.StockData))
                {
                    string json = streamReader.ReadToEnd();

                    ////Deserializing
                    List<StockReportModel> list = JsonConvert.DeserializeObject<List<StockReportModel>>(json);
                    double sum = 0;

                    //// Loops over the list
                    foreach (var item in list)
                    {
                        Console.WriteLine("{0} {1} {2}", item.Name, item.Price, item.Share + ":" + "Total Price of Company " + item.Name + " : " + (item.Price * item.Share));
                        sum += item.Price * item.Share;
                    }

                    //// Prints the stock report
                    Console.WriteLine("The total price of the stock = " + sum);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
