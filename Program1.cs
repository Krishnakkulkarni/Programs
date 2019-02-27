namespace FunctionalPrograms
{
 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

    /// <summary>
    /// To Replace a string
    /// </summary>
    public class Program1
    {
        /// <summary>
        /// define the entry point of the application
        /// </summary>
        /// <param name="args">The arguments.</param>
       public static void Main(string[] args)
       {
            int ch;
            do
            {
                Console.WriteLine(" 1.StringReplace \n 2.FlipCoin \n 3.LeapYear \n 4.PowerOfTwo \n 5.HarmonicNumber \n 6.PrimeFactor ");
                Console.WriteLine(" 7.Gambler \n 8.CouponNumber \n 9.2DArry \n 10.FindTriplets \n 11.FindThedistance \n");
                Console.WriteLine("enter the choose");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        StringReplace.Replace();
                        break;
                    case 2:
                        FlipCoin.CoinFlip();
                        break;
                    case 3:
                        LeapYear.Yearleap();
                        break;
                    case 4:
                        PowerOfTwo.TwoToThePower();
                        break;
                    case 5:
                        HarmonicNumber.Harmonicno();
                        break;
                    case 6:
                        PrimeFactor.Primefactor();
                        break;
                    case 7:
                        GamblerProg.Gamblerno();
                        break;
                    case 8:
                        CouponNumbers.Couponnumbers();
                        break;
                    case 9:
                        TwoDArray.TwodArray();
                        break;
                    case 10:
                        ThreeInteger.Integernumber();
                        break;
                    case 11:
                        DistancProgram.CalculateDistance();
                        break;

                    default:
                        Console.WriteLine("enter the valid choose");
                        break;
                }
            }
            while (ch != 0);
       }
    }
}