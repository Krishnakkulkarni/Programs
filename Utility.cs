//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DataStructurePrograms
{
using System;

        /// <summary>
        /// Utility class
        /// </summary>
        public class Utility
        {
            /// <summary>
            /// Checks the string is empty or Null.
            /// </summary>
            /// <param name="name">The name.</param>
            /// <returns>returns false if string is null or empty</returns>
            public static bool CheckString(string name)
            {
                try
                {
                    name = name.Trim();
                    if (string.IsNullOrEmpty(name))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

        /*****************************************************/
        /// <summary>
        /// returns true if string contain any special Character
        /// </summary>
        /// <param name="userName">Takes the username </param>
        /// <returns>returns  if string contains any Character </returns>
        public static bool ContainsCharacter(string userName)
        {
            try
            {
                char[] userNameCharacter = userName.ToCharArray();
                //// check each character in given string wheather it is a Character.
                for (int i = 0; i < userNameCharacter.Length; i++)
                {
                    if (!char.IsLetterOrDigit(userNameCharacter[i]))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /******************************************************/
        /// <summary>
        /// Determines whether the specified input is number.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        ///   <c>true</c> if the specified input is number; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNumber(string input)
        {
            try
            {
                if (input.Trim().Equals(string.Empty))
                {
                    return false;
                }

                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsDigit(input[i]) == false)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Checks the leap year.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>returns true or false</returns>
        /// <exception cref="Exception">throws exception</exception>
        public static bool CheckLeapYear(int year)
        {
            try
            {
                if (year % 4 == 0 && year % 100 != 0)
                {
                    return true;
                }
                else
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }

                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Days the of week.
        /// </summary>
        /// <param name="month">The month.</param>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>returns day</returns>
        public static int DayOfWeek(int month, int day, int year)
        {
            try
            {
                int y0 = year - ((14 - month) / 12);
                int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
                int m0 = month + (12 * ((14 - month) / 12)) - 2;
                int d0 = (day + x + (31 * m0 / 12)) % 7;
                return d0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /*********************************************************************/

        /// <summary>
        /// Anagrams the specified string1.
        /// </summary>
        /// <param name="string1">The string1.</param>
        /// <param name="string2">The string2.</param>
        /// <returns>returns true</returns>
        public static bool Anagram(string string1, string string2)
        {
            if (string1.Length == 1 || string2.Length == 1)
            {
                //// If string length are not equal returns false
                if (string1.Length != string2.Length)
                {
                    return false;
                }
            }

            char[] char1 = string1.ToLower().ToCharArray();
            char[] char2 = string2.ToLower().ToCharArray();

            //// Sorts the array using Array.Sort() method
            Array.Sort(char1);
            Array.Sort(char2);

            //// Storing charachters in String 
            string s3 = new string(char1);
            string s4 = new string(char2);

            //// Checks if the two arrays are equal or not
            if (s3.Equals(s4))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Determines whether [is prime number] [the specified n].
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>
        ///   <c>true</c> if [is prime number] [the specified n]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPrimeNumber(int n)
        {
            try
            {
                //// Checks if number is 0 or 1
                if (n == 0 || n == 1)
                {
                    return false;
                }

                //// Loops over to find out the number is prime or not
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
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