namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// To find Prime Factor
    /// </summary>
    public class PrimeFactor
    {
        /// <summary>
        /// define the entry point of the application
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Primefactor()
        {  
            Console.WriteLine("enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            UtilityClass.primefactor(n);
        }
    }
}