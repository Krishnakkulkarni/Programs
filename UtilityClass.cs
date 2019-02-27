namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Parameter
    /// </summary>
    public class UtilityClass
    {
        /******************ReplaceString*************************/

        public static void ReplaceString(string s, string s1)
        {
            try
            {
                if (s.Length < 3)
                {
                    Console.WriteLine("Less then three char");
                }
                else
                {
                    s1 = s1.Replace("<< UserName >>", s);
                    Console.WriteLine("{0}", s1);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************flipCoin*************************/

        public static void flipCoin(int n)
        {
            try
            {
                int heads = 0, tails = 0;
                Random random = new Random();
                double ran = 0.0;
                for (int i = 0; i < n; i++)
                {
                    ran = random.NextDouble();
                    if (ran < 0.5)
                    {
                        tails++;
                        Console.WriteLine("no of times of head {0}", ran);
                    }
                    else
                    {
                        heads++;
                        Console.WriteLine("no of times of tail {0}", ran);
                    }
                }

                double tails_per = (double)tails / n * 100;
                double heads_per = (double)heads / n * 100;
                Console.WriteLine("percentage of tails {0}", tails_per);
                Console.WriteLine("percentage of heads {0}", heads_per);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************LeapYear*************************/

        public static void Year(int year)
        {
            try
            {
                if ((year % 400 == 0) || ((year % 4 == 0) && (year != 0)))
                {
                    Console.WriteLine("leap year {0}", year);
                }
                else
                {
                    Console.WriteLine("not a leap year");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************PowerOfTwo*************************/

        public static void powerOfTwo(double n)
        {
            try
            {
                double power = 0, i;
                for (i = 0; i <= n; i++)
                {
                    if (n < 31)
                    {
                        power = Math.Pow(2, n);
                    }
                }

                Console.WriteLine("2^number is {0}", power);
                if (n > 31)
                {
                    Console.WriteLine("overflow");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************Harmonic*************************/

        public static void harmonic(double n)
        {
            try
            {
                double sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum = sum + (1.0 / i);
                }
                Console.WriteLine(sum);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        /******************primefactor*************************/

        public static void primefactor(int n)
        {
            try
            {
                Console.WriteLine("prime factors:");
                while (n % 2 == 0)
                {
                    Console.WriteLine("2");
                    n = n / 2;
                }
                for (int i = 3; i * i <= n; i += 3)
                {
                    while (n % 2 == 0)
                    {
                        // then prints value of i
                        Console.WriteLine("{0} ", i);
                        n = n / i;
                    }
                }

                if (n > 2)
                {
                    Console.WriteLine("{0}", n);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************Gambler*************************/

        public static void gamblernum(int stake, int goal, int n)
        {
            try
            {
                int bets = 0, wins = 0;
                Random ran = new Random();
                double v = 0.0;
                for (int i = 0; i < n; i++)
                {
                    int cash = stake;
                    while (cash > 0 && cash < goal)
                    {
                        bets++;
                        v = ran.NextDouble();
                        if (v < 0.5)
                        {
                            cash++;
                        }
                        else
                        {
                            cash--;
                        }
                    }

                    if (cash == goal)
                    {
                        wins++;
                    }
                }

                bets++;
                int loss = n - wins;
                Console.WriteLine("wins ={0}", wins);
                Console.WriteLine("loss ={0}", loss);
                double winPer = wins * 100 / n;
                double LossPer = loss * 100 / n;
                Console.WriteLine("percentage of no of win = {0}", wins);
                Console.WriteLine("percentage of no of loss = {0}", loss);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************CouponNumbers*************************/

        public static void GetCoupon(int number)
        {
            try
            {
                int[] GetCoupon = new int[number];
                int count = 0, i = 0, check = 0;
                Random random = new Random();
                Console.WriteLine("coupons :");
                while (i < number)
                {
                    count++;
                    int result = random.Next(0, 100);
                    Console.WriteLine(result);
                    for (int j = 0; j < number; j++)
                    {
                        if (GetCoupon[j] == result)
                        {
                            check = 1;
                        }
                    }

                    if (check == 0)
                    {
                        GetCoupon[i] = result;
                        i++;
                    }
                }
                int n = count - check;
                Console.WriteLine("count the elements = {0}", n);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************2DArray*************************/

        public static void Param(int row, int col)
        {
            try
            {
                int[,] mdarray = new int[row, col];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write("enter the element[{0},{1}]:", i, j);
                        mdarray[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("array sorted sucessfully");
                Console.ReadKey();
                for (int i = 0; i < row; i++)
                {
                    Console.WriteLine("\n");
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(mdarray[i, j] + " ");
                    }
                }
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************Sum of three Integer adds to ZERO*************************/

        public static void Integer(int[] arr, int number)
        {
            try
            {
                for (int i = 0; i < number - 2; i++)
                {
                    for (int j = i + 1; j < number - 1; j++)
                    {
                        for (int k = j + 1; k < number; k++)
                        {
                            if (arr[i] + arr[j] + arr[k] == 0)
                            {
                                Console.WriteLine("{0},{1},{2}", arr[i], arr[j], arr[k]);
                                Console.Write("\n");
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************To find Distance*************************/

        public static void Distance(int x, int y)
        {
            try
            {
                double a = (double)Math.Pow(x, 2);
                double b = (double)Math.Pow(y, 2);
                double dist = (double)Math.Sqrt(a + b);
                Console.WriteLine("The distance between x and y is {0}\n", dist);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************permutation*************************/

    }
}