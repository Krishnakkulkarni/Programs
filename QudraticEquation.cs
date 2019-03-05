//-----------------------------------------------------------------------
// <copyright file="QudraticEquation.cs" company="Bridgelabz">
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

    /// <summary>
    /// To find the Qudratic Equation
    /// </summary>
    public class QudraticEquation
    {
        /// <summary>
        /// Method to find the Qudratic Equation 
        /// </summary>
        public static void Equation()
        {
            try
            {
                Console.Write("\n");
                Console.Write("Calculate root of Quadratic Equation :\n");
                Console.Write("\n");

                Console.Write("Input the value of a ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the value of b ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the value of c ");
                int c = Convert.ToInt32(Console.ReadLine());
                UtilityClass.Quadratic(a, b, c);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}