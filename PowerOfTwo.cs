namespace FunctionalPrograms
{
 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

    /// <summary>
    /// Power of two
    /// </summary>
    public class PowerOfTwo
    {
        /// <summary>
        /// define the entry point of the application
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void TwoToThePower()
        {
            Console.WriteLine("enter the number");
            double n = Convert.ToDouble(Console.ReadLine());
            UtilityClass.powerOfTwo(n);
        }
    }
}