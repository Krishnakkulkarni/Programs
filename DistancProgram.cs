namespace FunctionalPrograms
{
 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;
 /// <summary>
 /// 
 /// </summary>
    public class DistancProgram
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
