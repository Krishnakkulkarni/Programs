//-----------------------------------------------------------------------
// <copyright file="InputForUnordered.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DataStructurePrograms.UnOrderedList
{
    using System;

    /// <summary>
    /// Takes input required for this class.
    /// </summary>
    public class InputForUnordered
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

               /* bool loopPath = true;
                while (loopPath)
                {
                    Console.WriteLine("Specify the File path");
                    path = Console.ReadLine();

                    if (File.Exists(path) == false)
                    {
                        Console.WriteLine("Specified Path does not exist");
                        continue;
                    }

                    loopPath = false;
                }
                */
                string dataFromFile = System.IO.File.ReadAllText("C:/Users/admin/source/repos/DataStructurePrograms/text.txt");
                Console.WriteLine(dataFromFile);
                string[] splitArray = dataFromFile.Split(' ');

                foreach (string word in splitArray)
                {
                    singlyLinkedList.Add(word.Trim());
                }

                Console.WriteLine("Enter the word you want to search");
                string wordToSearch = Console.ReadLine();

                if (singlyLinkedList.Contains(wordToSearch))
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

                singlyLinkedList.WriteToFile("C:/Users/admin/source/repos/DataStructurePrograms/text.txt");
                Console.Read();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
