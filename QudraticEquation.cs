namespace FunctionalPrograms
{
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    public class QudraticEquation
    {
        /// <summary>
        /// 
        /// </summary>
        public static void Equation()
        {
            Console.Write("\n");
            Console.Write("Calculate root of Quadratic Equation :\n");
            Console.Write("\n");

            Console.Write("Input the value of a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value of b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value of c : ");
            int c = Convert.ToInt32(Console.ReadLine());
            UtilityClass.Quadratic(a,b,c);
        }
    }
}
