//-----------------------------------------------------------------------
// <copyright file="SquareRoot.cs" company="Bridgelabz">
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
    /// To SquareRoot the given number
    /// </summary>
    public class SquareRoot
    {
        /// <summary>
        /// Method to take input and call for Main method
        /// </summary>
        public static void Square()
        {
            try
            {
                Console.WriteLine("Enter number to find Square root ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Square root = {0}");
                Utilityclass.Squareroot(number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
