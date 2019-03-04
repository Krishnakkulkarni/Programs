//-----------------------------------------------------------------------
// <copyright file="SwapNibbles.cs" company="Bridgelabz">
//     Company @ 2018 </copyright>
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
    /// Read an integer as an Input, convert to Binary using toBinary function
    /// </summary>
    public class SwapNibbles
    {
        /// <summary>
        /// Method to take input and call from Main method
        /// </summary>
        public static void BinaryToSwapNibbles()
        {
            try
            {
                Console.WriteLine("Enter the number to convert into binary");
                int number = Convert.ToInt32(Console.ReadLine());
                int[] binary = new int[10];
                binary = Utilityclass.NibblesSwap(number);
                Console.WriteLine("Befor swap =");
                Utilityclass.Display(binary);

                Utilityclass.NibblesSwap(binary);
                Console.WriteLine("After swap =");
                Utilityclass.Display(binary);
                int swap = Utilityclass.ToDecimal(binary);
                Console.WriteLine("Swap numbers are {0}", swap);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
