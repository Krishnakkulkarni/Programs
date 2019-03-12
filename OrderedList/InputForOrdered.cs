//-----------------------------------------------------------------------
// <copyright file="InputForOrdered.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DataStructurePrograms.OrderedList
{
    using System;
    using System.IO;

    /// <summary>
    /// Takes required inputs
    /// </summary>
    public class InputForOrdered
    {
        /// <summary>
        /// reads and writes to file
        /// </summary>
        public static void OrderedLinkedList()
        {
            try
            {
                string path = string.Empty;
                SinglyLinkedList singlyLinkedList = new SinglyLinkedList();

                //// reads all the data from the file .
                string dataFromFile = System.IO.File.ReadAllText("C:/Users/admin/source/repos/DataStructurePrograms/Text1.txt");
                Console.WriteLine(dataFromFile);
                string[] splitArray = dataFromFile.Split(' ');

                foreach (string word in splitArray)
                {
                    if (word.Trim() != string.Empty)
                    {
                        singlyLinkedList.Add(Convert.ToInt32(word.Trim()));
                    }
                }

                Console.WriteLine("Enter the number you want to search");
                string number = Console.ReadLine();

                if (UtilityClass.IsNumber(number) == false)
                {
                    Console.WriteLine("Enter only Numbers, try Again");
                    Console.Read();
                }

                int numberToSearch = Convert.ToInt32(number);

                //// if the number is found , gets deleted.
                if (singlyLinkedList.Contains(numberToSearch))
                {
                    if (singlyLinkedList.Delete(numberToSearch))
                    {
                        Console.WriteLine("Word " + numberToSearch + " has been removed ");
                    }
                }
                else
                {
                    singlyLinkedList.Add(numberToSearch);
                    Console.WriteLine("The word " + numberToSearch + " not found , Added to linked list and written to file");
                }

                singlyLinkedList.WriteToFile("C:/Users/admin/source/repos/DataStructurePrograms/Text1.txt");
                Console.Read();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}