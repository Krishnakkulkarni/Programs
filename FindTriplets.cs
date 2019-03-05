//-----------------------------------------------------------------------
// <copyright file="FindTriplets.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
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
     /// Method to Print the numbers 
     /// </summary>
        public static void Integernumber()
        {
            try
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
