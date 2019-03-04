//-----------------------------------------------------------------------
// <copyright file="ToBinary.cs" company="Bridgelabz">
//     Company @ 2018 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /// <summary>
    /// Convert decimal to Binary using toBinary function
    /// </summary>
    public class ToBinary
    {
        /// <summary>
        /// Method to take input and call from Main method
        /// </summary>
        public static void ConvertToBinary()
        {
            try
            {
                ArrayList binaryArrayList = new ArrayList();
                string binary = string.Empty;

                int userNumber = 0;
                bool loopNumber = true;

                while (loopNumber)
                {
                    Console.WriteLine("Enter the Number");
                    string stringUserNumber = Console.ReadLine();

                    if (Utilityclass.IsNumber(stringUserNumber) == false)
                    {
                        Console.WriteLine("Enter a valid Positive Integer");
                        continue;
                    }

                    userNumber = Convert.ToInt32(stringUserNumber);
                    loopNumber = false;
                }

                while (userNumber > 0)
                {
                    binary = binary + (userNumber % 2).ToString();
                    userNumber = userNumber / 2;
                }

                char[] binaryCharArray = binary.ToCharArray();

                for (int i = binaryCharArray.Length - 1; i >= 0; i--)
                {
                    Console.Write(binaryCharArray[i]);
                }

                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
