//-----------------------------------------------------------------------
// <copyright file="MonthlyPayment.cs" company="Bridgelabz">
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
    /// To find out the MonthlyPayment
    /// </summary>
    public class MonthlyPayment
    {
        /// <summary>
        /// Method to take input and call from Main method
        /// </summary>
        public static void PaymentMonthly()
        {
            try
            {
                Console.WriteLine("Enter years to payoff");
                double year = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter principal loan amount");
                double principal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter percent of interest");
                double percent = Convert.ToDouble(Console.ReadLine());
                Utilityclass.MonthlyPayment(year, principal, percent);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
