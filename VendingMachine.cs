//-----------------------------------------------------------------------
// <copyright file="VendingMachine.cs" company="Bridgelabz">
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
    /// Calculate how many notes are there using VendingMachine 
    /// </summary>
    public class VendingMachine
    {
        /// <summary>
        /// Method to take input and call from Main method
        /// </summary>
        public static void CalculateMinimumNote()
        {
            try
            {
                Console.WriteLine("enter any amount :");
                int amount = Convert.ToInt32(Console.ReadLine());
                Utilityclass.VendingMachine(amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
