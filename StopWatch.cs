//-----------------------------------------------------------------------
// <copyright file="StopWatch.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// To find elapsed time.
    /// </summary>
    public class StopWatch
    {
     /// <summary>
     /// Method to take the input and call from the main function
     /// </summary>
        public static void Watch()
        {
            try
            {
                Console.WriteLine("Enter the time");
                int start = Convert.ToInt32(Console.ReadLine());
                int end = Convert.ToInt32(Console.ReadLine());
                UtilityClass.Stopwatch(start, end);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
