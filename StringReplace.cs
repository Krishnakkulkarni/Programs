//-----------------------------------------------------------------------
// <copyright file="StringReplace.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// To replace a string by giving input from the user
    /// </summary>
    public class StringReplace
    {
        /// <summary>
        /// Method to take input and call from Main method
        /// </summary>
        public static void Replace()
        {
            try
            {
                Console.WriteLine("Enter your name");
                string s1 = "hello << UserName >>,how are you";
                string name = Console.ReadLine();
                UtilityClass.ReplaceString(name, s1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
