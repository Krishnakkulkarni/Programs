//-----------------------------------------------------------------------
// <copyright file="RegexClass.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.RegularExpression
{
    using System;

    /// <summary>
    /// Class to validate
    /// </summary>
    public class RegexClass
    {
        /// <summary>
        /// Method to check string 
        /// </summary>
        /// <param name="str">The string</param>
        /// <returns>returns string</returns>
        public static string IsString(string str)
        {
            int i = 0;
            //// returns the value of substring present in the string
            if (str.Contains(" "))
            {
                Console.WriteLine("Invalid input");
            }

            for (i = 0; i < 10; i++)
            {
                //// converts the integer value to equivalent string format
                if (str.Contains(i.ToString()))
                {
                    Console.WriteLine("you have entered the wrong input");
                }
            }

            return str;
        }
    }
}