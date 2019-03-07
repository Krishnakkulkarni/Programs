//-----------------------------------------------------------------------
// <copyright file="List.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace OrderedList
{
    using System;
    using DataStructurePrograms.OrderedList;

    /// <summary>
    /// Class List of Ordered List
    /// </summary>
    internal class List
    {
     /// <summary>
     /// Defines the entry point of the application.
     /// </summary>
     /// <param name="args">The arguments.</param>
        internal static void Ordered()
        {
            try
            {
                //// Console.Write("111");

                //// Creating stream reader for reading data from file
                string line = System.IO.File.ReadAllText(@"C:/Users/admin/source/repos/DataStructurePrograms/Text1.txt");
                //// Splits the line into characters

                if (line != null)
                {
                    //// Stores the character in string
                    string[] size = line.Split(' ');

                    //// Loops over string 
                    foreach (string string1 in size)
                    {
                        Console.Write("{0} ", string1);
                    }

                    int[] array1 = new int[size.Length];

                    //// Loops over the array to store it in array
                    for (int i = 0; i < array1.Length; i++)
                    {
                        array1[i] = int.Parse(size[i]);
                    }

                    Console.WriteLine();
                    //// Sorts the array using Array.Sort() method
                    Array.Sort(array1);

                    //// Creating single linked list object
                    SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
                    //// Console.Read();
                    //// Looping over the array to push elements
                    for (int j = 0; j < array1.Length; j++)
                    {
                        singlyLinkedList.Add(array1[j]);
                    }

                    //// Enter the number to be searched
                    Console.WriteLine("Enter the number to search");
                    int element = Convert.ToInt32(Console.ReadLine());

                    //// Checks if word searched is in the file
                    if (singlyLinkedList.Search(element))
                    {
                        //// Removes the element
                        singlyLinkedList.Remove(singlyLinkedList, element);

                        singlyLinkedList.Print();
                    }
                    else
                    {
                        //// If word is not in file it adds it to file
                        Console.WriteLine("List does not contain ");
                        singlyLinkedList.Add(element);

                        singlyLinkedList.Print();
                    }
                }
                //// Console.Write("Name");
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}