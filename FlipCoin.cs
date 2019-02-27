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
        /// <param name="args">parameter n</param>
        public static void CoinFlip()
        { 
            Console.WriteLine("enter the no of times to flip coin ");
            int n = Convert.ToInt32(Console.ReadLine());
            UtilityClass.flipCoin(n);
        }
    }
}
