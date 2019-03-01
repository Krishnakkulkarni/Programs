//-----------------------------------------------------------------------
// <copyright file="DistanceProgram.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
 using System;

 /// <summary>
 /// 
 /// </summary>
    public class DistanceProgram
    {
     /// <summary>
     /// 
     /// </summary>
        public static void CalculateDistance()
        {
            Console.WriteLine("enter the  x and y");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            UtilityClass.Distance(x, y);
        }
    }
}
