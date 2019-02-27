namespace FunctionalPrograms
{
 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

    /// <summary>
    /// To find Coupon Numbers
    /// </summary>
    public class CouponNumbers
    {
     /// <summary>
     /// 
     /// </summary>
        public static void Couponnumbers()
        {
            Console.WriteLine("enter the no");
            int number = Convert.ToInt32(Console.ReadLine());
            UtilityClass.GetCoupon(number);
        }
    }
}
