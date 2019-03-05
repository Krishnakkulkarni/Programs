//-----------------------------------------------------------------------
// <copyright file="GamblerProgram.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
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
     /// Method to take the random number
     /// </summary>
        public static void Gambler()
        {
            try
            {
                Console.WriteLine("enter the $stake number ");
                int stake = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the goal number ");
                int goal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the no number ");
                int number = Convert.ToInt32(Console.ReadLine());
                UtilityClass.Gamblernumber(stake, goal, number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
