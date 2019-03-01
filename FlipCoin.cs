//-----------------------------------------------------------------------
// <copyright file="FlipCoin.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
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
            Console.WriteLine("Enter the number of times to flip coin ");
            int noOfTimes = Convert.ToInt32(Console.ReadLine());
            UtilityClass.FlipCoin(noOfTimes);
        }
    }
}
