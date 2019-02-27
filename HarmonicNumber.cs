namespace FunctionalPrograms
{
 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

    /// <summary>
    /// To find a harmonic number
    /// </summary>
    public class HarmonicNumber
    { 
     /// <summary>
     /// define the entry point of the application
     /// </summary>
     /// <param name="args">The arguments.</param>
        public static void Harmonicno()
        {
            Console.WriteLine("enter the number");
            double n = Convert.ToDouble(Console.ReadLine());
            UtilityClass.harmonic(n);
        }
    }
}
