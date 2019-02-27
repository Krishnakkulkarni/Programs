namespace FunctionalPrograms
{
 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

    /// <summary>
    /// To display two dimension array
    /// </summary>
    public class TwoDArray
    {
     /// <summary>
     /// 
     /// </summary>
        public static void TwodArray()
        {
            Console.WriteLine("enter the no of rows:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the no of rows:");
            int col = Convert.ToInt32(Console.ReadLine());
            UtilityClass.Param(row, col);
        }
    }
}
