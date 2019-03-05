//-----------------------------------------------------------------------
// <copyright file="FlipCoin.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FunctionalPrograms;

    /// <summary>
    /// Flip Coin and print percentage of Heads and Tails
    /// </summary>
    public class FlipCoin
    {
        /// <summary>
        /// Define the entry point of the application
        /// </summary>
        public static void CoinFlip()
        {
            try
            {
                Console.WriteLine("Enter the number of times to flip coin ");
                int noOfTimes = Convert.ToInt32(Console.ReadLine());
                UtilityClass.FlipCoin(noOfTimes);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
