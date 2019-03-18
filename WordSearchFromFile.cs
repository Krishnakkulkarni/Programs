//-----------------------------------------------------------------------
// <copyright file="WordSearchFromFile.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace AlgorithmPrograms
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /// <summary>
    /// To Search word from file
    /// </summary>
    public class WordSearchFromFile
    {
        /// <summary>
        /// Method to take input and call from Main method
        /// </summary>
        public static void WordSearchfromFile()
        {
            try
            {
                string line = System.IO.File.ReadAllText("C:/Users/admin/source/repos/ConsoleApp1/text.txt");
                Console.WriteLine(line);
                Console.WriteLine("Enter the word to search");
                string key = Console.ReadLine();
                Utilityclass.SearchWord(line,key);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
