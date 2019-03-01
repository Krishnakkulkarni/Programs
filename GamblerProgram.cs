//-----------------------------------------------------------------------
// <copyright file="GamblerProgram.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// To find gambler
    /// </summary>
    public class GamblerProgram
    {
     /// <summary>
     /// 
     /// </summary>
        public static void Gambler()
        {
            Console.WriteLine("enter the $stake number ");
            int stake = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the goal number ");
            int goal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the no number ");
            int number = Convert.ToInt32(Console.ReadLine());
            UtilityClass.Gamblernumber(stake, goal, number);
        }
    }
}
