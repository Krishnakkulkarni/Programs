//-----------------------------------------------------------------------
// <copyright file="StringReplace.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public class StringReplace
    {
        /// <summary>
        /// 
        /// </summary>
        public static void Replace()
        {
            Console.WriteLine("Enter your name");
            string s1 = "hello << UserName >>,how are you";
            string s = Console.ReadLine();
            UtilityClass.ReplaceString(s, s1);
        }
    }
}
