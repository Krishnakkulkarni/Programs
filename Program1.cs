//-----------------------------------------------------------------------
// <copyright file="Program1.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
 using System;

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
            try
            {
                int choose;
                string yes;
                do
                {
                    Console.WriteLine(" 1.StringReplace \n 2.FlipCoin \n 3.LeapYear \n 4.PowerOfTwo \n 5.HarmonicNumber \n 6.PrimeFactor ");
                    Console.WriteLine(" 7.Gambler \n 8.CouponNumber \n 9.2DArry \n 10.FindTriplets \n 11.FindThedistance \n 12.permutation ");
                    Console.WriteLine(" 13.StopWatch \n 14.TIC_TAC_TOE_GAME \n 15.QudraticEquation \n 16.WindChill");
                    Console.WriteLine("enter the your choose");
                    choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
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
                        HarmonicNumber.Harmonicnumber();
                        break;
                    case 6:
                        PrimeFactor.Primefactor();
                        break;
                    case 7:
                        GamblerProgram.Gambler();
                        break;
                    case 8:
                        CouponNumbers.Couponnumbers();
                        break;
                    case 9:
                        TwoDArray.TwodArray();
                        break;
                    case 10:
                        FindTriplets.Integernumber();
                        break;
                    case 11:
                        DistanceProgram.CalculateDistance();
                        break;
                    case 12:
                        Permutation.PermutationNumber();
                        break;
                    case 13:
                        StopWatch.Watch();
                        break;
                    case 14:
                        Tic_Tac_Toe.Tic_tac_toe();
                        break;
                    case 15:
                        QudraticEquation.Equation();
                        break;
                    case 16:
                        WindChill.Wind();
                        break;
                    default:
                        Console.WriteLine("enter the valid choose");
                        break;
                }

                Console.WriteLine("do you want continue");
                yes = Console.ReadLine();
            }
                while (choose != 0 && yes != "no");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}