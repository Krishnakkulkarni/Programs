//-----------------------------------------------------------------------
// <copyright file="Inventory.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.InventoryManager
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// Class for Inventory
    /// </summary>
    public class Inventory
    {
        /// <summary>
        /// Inventories the data.
        /// </summary>
        public void InventoryData()
        {
            try
            {
                CoreClass coreClass = new CoreClass();

                //// Opens the file and reads it
                using (StreamReader streamReader = File.OpenText(coreClass.InventoryData))
                {
                    string json = streamReader.ReadToEnd();

                    //// Converting the json format to .net
                    InventoryDetails list = JsonConvert.DeserializeObject<InventoryDetails>(json);

                    //// Stores the data in the list
                    IList<InventoryModel> rice = list.Rices;
                    Console.WriteLine("Types of Rice");
                    Console.WriteLine("Name" + "   " + "Price" + "   " + "Weight");
                    double priceOfRice = 0;

                    //// Loops over the rice object
                    foreach (var item in rice)
                    {
                        Console.WriteLine(item.Name + "   " + item.Price + "      " + item.Weight);
                        priceOfRice = priceOfRice + (item.Price * item.Weight);
                    }

                    //// Prints the total price of the rice
                    Console.WriteLine("Total price of rice is " + priceOfRice);
                    Console.WriteLine();

                    ///// Stores the data in list
                    IList<InventoryModel> wheat = list.Wheat;
                    Console.WriteLine("Types of Wheat");
                    Console.WriteLine("Name" + "   " + "Price" + "   " + "Weight");
                    double priceOfWheat = 0;

                    //// loops over the wheat object
                    foreach (var item in wheat)
                    {
                        Console.WriteLine(item.Name + "   " + item.Price + "      " + item.Weight);
                        priceOfWheat = priceOfWheat + (item.Price * item.Weight);
                    }

                    //// Prints the price of wheat
                    Console.WriteLine("Total price of wheat is " + priceOfWheat);
                    Console.WriteLine();

                    //// Store the pulses in the list
                    IList<InventoryModel> pulses = list.Pulses;
                    Console.WriteLine("Types of Pulses");
                    Console.WriteLine("Name" + "   " + "Price" + "   " + "Weight");
                    double priceOfPulses = 0;

                    //// Loops over the pulses object
                    foreach (var item in pulses)
                    {
                        Console.WriteLine(item.Name + "   " + item.Price + "      " + item.Weight);
                        priceOfPulses = priceOfPulses + (item.Price * item.Weight);
                    }

                    //// Prints the price of the pulses
                    Console.WriteLine("Total price of pulses is " + priceOfPulses);
                    Console.WriteLine();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
