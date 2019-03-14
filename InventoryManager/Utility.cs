//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.InventoryManager
{
    using System;

    /// <summary>
    /// Class for utility
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Determines whether the specified string is string.
        /// </summary>
        /// <param name="str">The string.</param>
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

        /// <summary>
        /// Method to check number
        /// </summary>
        /// <param name="number">The number</param>
        /// <returns>return number</returns>
        public static bool IsNumber(double number)
        {
            try
            {
                if (number < 0 || number == 0)
                {
                    Console.WriteLine("Enter a positive number");
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return true;
        }

        /// <summary>
        /// Method to check string
        /// </summary>
        /// <param name="str">The string</param>
        /// <returns>returns string</returns>
        public static bool IsString1(string str)
        {
            try
            {
                int length = str.Length;

                //// returns the value of substring in a string
                if (str.Contains(" "))
                {
                    Console.WriteLine("Invalid input");
                    return false;
                }

                //// Converts the integer value to equivalent string
                for (int i = 0; i < 10; i++)
                {
                    if (str.Contains(i.ToString()))
                    {
                        Console.WriteLine("You have Entered the wrong input");
                        return false;
                    }
                }

                if (str.Contains("@") || str.Contains("#") || str.Contains("$") || str.Contains("%"))
                {
                    Console.WriteLine("Invalid input");
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return true;
        }
    }
}