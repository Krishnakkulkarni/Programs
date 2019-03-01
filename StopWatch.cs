//-----------------------------------------------------------------------
// <copyright file="StopWatch.cs" company="Bridgelabz">
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

    /// <summary>
    /// 
    /// </summary>
    public class StopWatch
    {
     /// <summary>
     /// 
     /// </summary>
        public static void Watch()
        {
            Console.WriteLine("Enter the time");
            int start = Convert.ToInt32(Console.ReadLine());
            int end = Convert.ToInt32(Console.ReadLine());
            UtilityClass.Stopwatch(start, end);
        }
    }
}
