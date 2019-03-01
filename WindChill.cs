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
    class WindChill
    {
        /// <summary>
        /// 
        /// </summary>
        public static void Wind()
        {
            Console.WriteLine("enter the temperature ");
            double t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the speed ");
            double v = Convert.ToDouble(Console.ReadLine());
            UtilityClass.Chill(t, v);
        }
    }
}
