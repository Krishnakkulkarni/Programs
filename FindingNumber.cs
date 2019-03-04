//-----------------------------------------------------------------------
// <copyright file="FindingNumber.cs" company="Bridgelabz">
//     Company @ 2018 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /// <summary>
    /// To find the Own number
    /// </summary>
    public class FindingNumber
    {
        /// <summary>
        /// Method to take input and call for Main method
        /// </summary>
        public static void FindNumber()
        {
            try
            {
                Console.WriteLine("try any number");
                Console.WriteLine("Enter your Maximum number ");
                int l = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 0 if number is smaller than middle number untill you get your number");
                Console.WriteLine("Enter 1 if number is greater than middle number untill you get your number");

                int[] array = new int[l];
                for (int i = 0; i < l; i++)
                {
                    array[i] = i;
                }

                Utilityclass.TryYournumber(array);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
