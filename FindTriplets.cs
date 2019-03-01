//-----------------------------------------------------------------------
// <copyright file="FindTriplets.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
 using System;

    /// <summary>
    /// Sum of three Integer adds to ZERO
    /// </summary>
    public class FindTriplets
    {
     /// <summary>
     /// 
     /// </summary>
        public static void Integernumber()
        {
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the array element");
            int[] array = new int[number];
            for (int i = 0; i < number; i++)
            {
              array[i] = Convert.ToInt32(Console.ReadLine());
            }

            UtilityClass.Integer(array, number);
        }
    }
}
