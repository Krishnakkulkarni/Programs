//-----------------------------------------------------------------------
// <copyright file="DistanceProgram.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// To find the distance between two points
    /// </summary>
    public class DistanceProgram
    {
        /// <summary>
        /// Method to Calculate the distance
        /// </summary>
        public static void CalculateDistance()
        {
            try
            {
                Console.WriteLine("enter the  x and y");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                UtilityClass.Distance(x, y);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
