//-----------------------------------------------------------------------
// <copyright file="TwoDArray.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
 using System;

    /// <summary>
    /// To display two dimension array
    /// </summary>
    public class TwoDArray
    {
     /// <summary>
     /// Method to take input as a array
     /// </summary>
        public static void TwodArray()
        {
            Console.WriteLine("enter the no of rows:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the no of rows:");
            int column = Convert.ToInt32(Console.ReadLine());
            UtilityClass.Parameter(row, column);
        }
    }
}