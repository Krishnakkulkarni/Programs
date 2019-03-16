//-----------------------------------------------------------------------
// <copyright file="InventoryManager.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.InventoryManager
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Class for InventoryManager
    /// </summary>
    public class InventoryManager
    {
        /// <summary>
        /// Managers this instance.
        /// </summary>
        public void Manager()
        {
            try
            {
                char character = 'n';
                do
                {
                    Console.WriteLine("1.  adding  rice");
                    Console.WriteLine("2.  adding wheat");
                    Console.WriteLine("3.  adding pulses");
                    Console.WriteLine("4.  deleting rice");
                    Console.WriteLine("5.  deleting wheat");
                    Console.WriteLine("6.  deleting pulses");
                    Console.WriteLine("7.  Updating rice");
                    Console.WriteLine("8.  Updating wheat");
                    Console.WriteLine("9.  Updating pulses");
                    Console.WriteLine("10. viewing details");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            this.AddRice();
                            break;

                        case 2:
                            this.AddWheat();
                            break;

                        case 3:
                            this.AddPulses();
                            break;

                        case 4:
                            this.DeleteRice();
                            break;

                        case 5:
                            this.DeleteWheat();
                            break;

                        case 6:
                            this.DeletePulse();
                            break;

                        case 7:
                            this.Update();
                            break;

                        case 8:
                            this.UpdateWheat();
                            break;

                        case 9:
                            this.UpdatePulses();
                            break;

                        case 10:
                            this.ViewDetails();
                            break;

                        default:
                            Console.WriteLine("Enter the proper number");
                            break;
                    }
                }
                while (character != 'n');
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Adds the rice.
        /// </summary>
        public void AddRice()
        {
            try
            {
                CoreClass constants = new CoreClass();

                //// Opens and reads data from json file
                using (StreamReader streamReader = File.OpenText(constants.InventoryData))
                {
                    string json = streamReader.ReadToEnd();

                    //// Prsing the json
                    var jsonObject = JObject.Parse(json);

                    //// Deserialising
                    InventoryDetails list = JsonConvert.DeserializeObject<InventoryDetails>(json);

                    //// Adding rice object to the list
                    IList<InventoryModel> rice = list.Rices;

                    //// Takes in the necessary data
                    Console.WriteLine("Enter name  : ");
                    var name = Console.ReadLine();
                    if (Utility.IsString1(name))
                    {
                        Console.WriteLine("Enter price : ");
                    }

                    double price = Convert.ToDouble(Console.ReadLine());
                    if (Utility.IsNumber(price))
                    {
                        Console.WriteLine("Enter the weight");
                    }

                    double weight = Convert.ToDouble(Console.ReadLine());
                    if (Utility.IsNumber(weight))
                    {
                        //// Creating the inventory model and adding the requried data
                        InventoryModel inventoryModel = new InventoryModel()
                        {
                            Name = name,
                            Price = price,
                            Weight = weight
                        };
                        rice.Add(inventoryModel);

                        //// Loops over the rice object
                        foreach (var items in rice)
                        {
                            Console.WriteLine(items.Name + " " + items.Price + " " + items.Weight);
                        }

                        //// Serializing and writing data to the file
                        string output = JsonConvert.SerializeObject(list);
                        File.WriteAllText(constants.InventoryDetails, output);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Adds the wheat.
        /// </summary>
        public void AddWheat()
        {
            try
            {
                CoreClass coreClass = new CoreClass();

                //// Opens and reads data from json file
                using (StreamReader streamReader = File.OpenText(coreClass.InventoryData))
                {
                    string json = streamReader.ReadToEnd();

                    //// Prsing the json
                    var jsonObject = JObject.Parse(json);

                    //// Deserialising
                    InventoryDetails list = JsonConvert.DeserializeObject<InventoryDetails>(json);

                    //// Adding wheat object to the list
                    IList<InventoryModel> wheat = list.Wheat;

                    //// Takes in the necessary data
                    Console.WriteLine("Enter name  : ");
                    var name = Console.ReadLine();
                    if (Utility.IsString1(name))
                    {
                        Console.WriteLine("Enter price : ");
                    }

                    double price = Convert.ToDouble(Console.ReadLine());
                    if (Utility.IsNumber(price))
                    {
                        Console.WriteLine("Enter weight");
                    }

                    double weight = Convert.ToDouble(Console.ReadLine());
                    if (Utility.IsNumber(weight))
                    {
                        //// Creating the inventory model and adding the requried data
                        InventoryModel inventoryModel = new InventoryModel()
                        {
                            Name = name,
                            Price = price,
                            Weight = weight
                        };
                        wheat.Add(inventoryModel);

                        //// Loops over the rice object
                        foreach (var items in wheat)
                        {
                            Console.WriteLine(items.Name + " " + items.Price + " " + items.Weight);
                        }

                        //// Serializing and writing data to the file
                        string output = JsonConvert.SerializeObject(list);
                        File.WriteAllText(coreClass.InventoryDetails, output);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Adds the rice.
        /// </summary>
        public void AddPulses()
        {
            try
            {
                CoreClass coreClass = new CoreClass();

                //// Opens and reads data from json file
                using (StreamReader streamReader = File.OpenText(coreClass.InventoryData))
                {
                    string json = streamReader.ReadToEnd();

                    //// Prsing the json
                    var jsonObject = JObject.Parse(json);

                    //// Deserialising
                    InventoryDetails list = JsonConvert.DeserializeObject<InventoryDetails>(json);

                    //// Adding wheat object to the list
                    IList<InventoryModel> pulses = list.Pulses;

                    //// Takes in the necessary data
                    Console.WriteLine("Enter name  : ");
                    var name = Console.ReadLine();
                    if (Utility.IsString1(name))
                    {
                        Console.WriteLine("Enter price : ");
                    }

                    double price = Convert.ToDouble(Console.ReadLine());
                    if (Utility.IsNumber(price))
                    {
                        Console.WriteLine("Enter the weight");
                    }

                    double weight = Convert.ToDouble(Console.ReadLine());
                    if (Utility.IsNumber(weight))
                    {
                        //// Creating the inventory model and adding the requried data
                        InventoryModel inventoryModel = new InventoryModel()
                        {
                            Name = name,
                            Price = price,
                            Weight = weight
                        };
                        pulses.Add(inventoryModel);

                        //// Loops over the rice object
                        foreach (var items in pulses)
                        {
                            Console.WriteLine(items.Name + " " + items.Price + " " + items.Weight);
                        }
                        
                        //// Serializing and writing data to the file
                        string output = JsonConvert.SerializeObject(list);
                        File.WriteAllText(coreClass.InventoryDetails, output);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Reads the file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>returns string</returns>
        public string ReadFile(string path)
        {
            //// used to read the file
            using (StreamReader streamReader = File.OpenText(path))
            {
                string json = streamReader.ReadToEnd();
                streamReader.Close();
                return json;
            }
        }

        /// <summary>
        /// Deletes the rice.
        /// </summary>
        public void DeleteRice()
        {
            try
            {
                CoreClass coreClass = new CoreClass();

                //// Used to read all data from the file
                var json = File.ReadAllText(coreClass.InventoryData);
                try
                {
                    //// Parsing the object
                    var jsonObject = JObject.Parse(json);

                    //// Storing the object in jarray
                    JArray riceArray = (JArray)jsonObject["Rices"];
                    Console.WriteLine(riceArray);
                    Console.Write("Enter nameto Delete rice : ");
                    var riceName = Console.ReadLine();

                    //// checks if ricename is not null
                    if (!riceName.Equals(null))
                    {
                        var companyName = string.Empty;

                        //// Rice to be deleted
                        var riceToDeleted = riceArray.FirstOrDefault(obj => obj["name"].Value<string>().Equals(riceName));

                        riceArray.Remove(riceToDeleted);

                        //// Serializing 
                        string output = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                        File.WriteAllText(coreClass.InventoryData, output);
                        Console.WriteLine(riceArray);
                    }
                    else
                    {
                        Console.Write("Invalid rice Name, Try Again!");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Deletes the rice.
        /// </summary>
        public void DeleteWheat()
        {
            try
            {
                CoreClass coreClass = new CoreClass();

                //// Used to read all data from the file
                var json = File.ReadAllText(coreClass.InventoryData);
                try
                {
                    //// Parsing the object
                    var jsonObject = JObject.Parse(json);

                    //// Storing the object in jarray
                    JArray wheatArray = (JArray)jsonObject["Wheat"];
                    Console.WriteLine(wheatArray);
                    Console.Write("Enter name to Delete pulse : ");
                    var wheatName = Console.ReadLine();

                    //// checks if ricename is not null
                    if (!wheatName.Equals(null))
                    {
                        var companyName = string.Empty;

                        //// Rice to be deleted
                        var wheatToDeleted = wheatArray.FirstOrDefault(obj => obj["name"].Value<string>().Equals(wheatName));

                        wheatArray.Remove(wheatToDeleted);

                        //// Serializing 
                        string output = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                        File.WriteAllText(coreClass.InventoryData, output);
                        Console.WriteLine(wheatArray);
                    }
                    else
                    {
                        Console.Write("Invalid wheat Name, Try Again!");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Deletes the pulse.
        /// </summary>
        public void DeletePulse()
        {
            try
            {
                CoreClass coreClass = new CoreClass();

                //// Used to read all data from the file
                var json = File.ReadAllText(coreClass.InventoryData);
                try
                {
                    //// Parsing the object
                    var jsonObject = JObject.Parse(json);

                    //// Storing the object in jarray
                    JArray pulseArray = (JArray)jsonObject["Pulses"];
                    Console.WriteLine(pulseArray);
                    Console.Write("Enter name to Delete pulse : ");
                    var pulseName = Console.ReadLine();

                    //// checks if ricename is not null
                    if (!pulseName.Equals(null))
                    {
                        var companyName = string.Empty;

                        //// Rice to be deleted
                        var pulseToDeleted = pulseArray.FirstOrDefault(obj => obj["name"].Value<string>().Equals(pulseName));

                        pulseArray.Remove(pulseToDeleted);

                        //// Serializing 
                        string output = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                        File.WriteAllText(coreClass.InventoryData, output);
                        Console.WriteLine(pulseArray);
                    }
                    else
                    {
                        Console.Write("Invalid pulse Name, Try Again!");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Updates this instance.
        /// </summary>
        public void Update()
        {
            CoreClass coreClass = new CoreClass();
            string json = File.ReadAllText(coreClass.InventoryData);

            try
            {
                //// parsing the obk=ject
                var jsonObject = JObject.Parse(json);
                JArray riceArray = (JArray)jsonObject["Rices"];
                Console.Write("Enter rice name to Update : ");
                var riceName = Console.ReadLine();

                //// Checks if ricename is not null
                if (!riceName.Equals(null))
                {
                    //// Takes in the price
                    Console.Write("Enter new price : ");
                    var priceOfRice = Convert.ToDouble(Console.ReadLine());

                    if (priceOfRice > 0)
                    {
                        //// Loops over to upgrade price
                        foreach (var company in riceArray.Where(obj => obj["name"].Value<string>().Equals(riceName)))
                        {
                            company["price"] = priceOfRice != 0 ? priceOfRice : 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter a positive input");
                    }

                    //// Takes in the weight
                    Console.Write("Enter new weight : ");
                    var newWeight = Convert.ToDouble(Console.ReadLine());

                    if (newWeight > 0)
                    {
                        foreach (var company in riceArray.Where(obj => obj["name"].Value<string>().Equals(riceName)))
                        {
                            company["weight"] = newWeight != 0 ? newWeight : 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter a positive input");
                    }
                    //// Loops over to upgrade weight
                    jsonObject["Rices"] = riceArray;

                    //// Performing serialization
                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(coreClass.InventoryData, output);
                }
                else
                {
                    //// Prints if its invalid
                    Console.Write("Invalid rice name, Try Again!");
                    this.Update();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Update Error : " + exception.Message.ToString());
            }
        }

        /// <summary>
        /// Updates this instance.
        /// </summary>
        public void UpdateWheat()
        {
            CoreClass coreClass = new CoreClass();
            string json = File.ReadAllText(coreClass.InventoryData);

            try
            {
                //// parsing the obk=ject
                var jsonObject = JObject.Parse(json);
                JArray wheatArray = (JArray)jsonObject["Wheat"];
                Console.Write("Enter wheat name to Update : ");
                var wheatName = Console.ReadLine();

                //// Checks if ricename is not null
                if (!wheatName.Equals(null))
                {
                    //// Takes in the price
                    Console.Write("Enter new price : ");
                    var priceOfWheat = Convert.ToDouble(Console.ReadLine());

                    //// Loops over to upgrade price
                    foreach (var company in wheatArray.Where(obj => obj["name"].Value<string>().Equals(wheatName)))
                    {
                        company["price"] = priceOfWheat != 0 ? priceOfWheat : 0;
                    }

                    //// Takes in the weight
                    Console.Write("Enter new weight : ");
                    var newWeight = Convert.ToDouble(Console.ReadLine());

                    //// Loops over to upgrade weight
                    foreach (var company in wheatArray.Where(obj => obj["name"].Value<string>().Equals(wheatName)))
                    {
                        company["weight"] = newWeight != 0 ? newWeight : 0;
                    }

                    jsonObject["Wheat"] = wheatArray;

                    //// Performing serialization
                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(coreClass.InventoryData, output);
                }
                else
                {
                    //// Prints if its invalid
                    Console.Write("Invalid wheat name, Try Again!");
                    this.Update();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Update Error : " + exception.Message.ToString());
            }
        }

        /// <summary>
        /// Updates this instance.
        /// </summary>
        public void UpdatePulses()
        {
            CoreClass coreClass = new CoreClass();
            string json = File.ReadAllText(coreClass.InventoryData);

            try
            {
                //// parsing the obk=ject
                var jsonObject = JObject.Parse(json);
                JArray pulseArray = (JArray)jsonObject["Pulses"];
                Console.Write("Enter pulse name to Update : ");
                var pulseName = Console.ReadLine();

                //// Checks if ricename is not null
                if (!pulseName.Equals(null))
                {
                    //// Takes in the price
                    Console.Write("Enter new price : ");
                    var priceOfWheat = Convert.ToDouble(Console.ReadLine());

                    //// Loops over to upgrade price
                    foreach (var company in pulseArray.Where(obj => obj["name"].Value<string>().Equals(pulseName)))
                    {
                        company["price"] = priceOfWheat != 0 ? priceOfWheat : 0;
                    }

                    //// Takes in the weight
                    Console.Write("Enter new weight : ");
                    var newWeight = Convert.ToDouble(Console.ReadLine());

                    //// Loops over to upgrade weight
                    foreach (var company in pulseArray.Where(obj => obj["name"].Value<string>().Equals(pulseName)))
                    {
                        company["weight"] = newWeight != 0 ? newWeight : 0;
                    }

                    jsonObject["Pulses"] = pulseArray;

                    //// Performing serialization
                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(coreClass.InventoryData, output);
                }
                else
                {
                    //// Prints if its invalid
                    Console.Write("Invalid pulse name, Try Again!");
                    this.Update();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Update Error : " + exception.Message.ToString());
            }
        }

        /// <summary>
        /// Views the details.
        /// </summary>
        public void ViewDetails()
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
