//-----------------------------------------------------------------------
// <copyright file="CouponNumbers.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
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
        /// Method to find coupon number
        /// </summary>
        public static void Couponnumbers()
        {
            try
            {
                Console.WriteLine("enter the no");
                int number = Convert.ToInt32(Console.ReadLine());
                UtilityClass.GetCoupon(number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } 
    }
}