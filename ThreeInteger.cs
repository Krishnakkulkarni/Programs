namespace FunctionalPrograms
{
 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

    /// <summary>
    /// Sum of three Integer adds to ZERO
    /// </summary>
    public class ThreeInteger
    {
     /// <summary>
     /// 
     /// </summary>
        public static void Integernumber()
        {
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the array element");
            int[] arr = new int[number];
            for (int i = 0; i < number; i++)
            {
              arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            UtilityClass.Integer(arr,number);
        }
    }
}
