//-----------------------------------------------------------------------
// <copyright file="LinkedList_UnOrdered.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DataStructurePrograms.Unordered
{
 using System;
 using System.Collections.Generic;

    /// <summary>
    /// class for Unordered List
    /// </summary>
    public class LinkedList_UnOrdered
    {
        /// <summary>
        /// Unordered LinkedList
        /// </summary>
        public static void UnOrderedList()
        {
            try
            {
                string path = string.Empty;
                SinglyLinkedList<string> singlyLinkedList = new SinglyLinkedList<string>();

                string dataFromFile = System.IO.File.ReadAllText("C:/Users/admin/source/repos/DataStructurePrograms/text.txt");
                string[] splitArray = dataFromFile.Split();
                foreach (string text in splitArray)
                {
                    Console.Write(text + "\t");
                }

                Console.WriteLine();
                
                foreach (string word in splitArray)
                {
                    singlyLinkedList.Add(word.Trim());
                }

                Console.WriteLine("Enter the word you want to search");
                string wordToSearch = Console.ReadLine();

                if (singlyLinkedList.Contain(wordToSearch))
                {
                    if (singlyLinkedList.Delete(wordToSearch))
                    {
                        Console.WriteLine("Word " + wordToSearch + " has been removed ");
                    }
                }
                else
                {
                    singlyLinkedList.Add(wordToSearch);
                    Console.WriteLine("The word " + wordToSearch + " not found , Added to linked list and written to file");
                }

                singlyLinkedList.WriteToFile(path);
                Console.Read();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}