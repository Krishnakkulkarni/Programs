//-----------------------------------------------------------------------
// <copyright file="UtilityClass.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
 using System;
    using System.Text.RegularExpressions;
    using System.Threading;

    /// <summary>
    /// Core classes
    /// </summary>
    public class UtilityClass
    {
        /// <summary>
        /// Taking flag as a private
        /// </summary>
        /******************ReplaceString*************************/

        /// <summary>
        /// To replace string
        /// </summary>
        /// <param name="name">string name as a input parameter</param>
        /// <param name="s1">proper name should be entered as a s1 parameter</param>
        public static void ReplaceString(string name, string s1)
        {
            try
            {
                //// validation to accept only string 
                Match match = Regex.Match(name, "[a-z]", RegexOptions.IgnoreCase);
                if (name.Length >= 3 && match.Success)
                {
                    s1 = s1.Replace("<< UserName >>", name);
                    Console.WriteLine("{0}", s1);
                }
                else
                {
                    Console.WriteLine("Should have more then three character");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************flipCoin*************************/

        /// <summary>
        /// To check the number of times the coin flip
        /// </summary>
        /// <param name="noOfTimes">noOfTimes is a parameter</param>
        public static void FlipCoin(int noOfTimes)
        {
            try
            {
                int heads = 0, tails = 0;
                Random random = new Random();
                double ran = 0.0;

                // loop to iterate number of times coin flip
                for (int i = 0; i < noOfTimes; i++)
                {
                    ran = random.NextDouble();
                    if (ran < 0.5)
                    {
                        tails++;
                        Console.WriteLine("no of times of head = {0}", ran);
                    }
                    else
                    {
                        heads++;
                        Console.WriteLine("no of times of tail = {0}", ran);
                    }
                }

                double tails_percentage = (double)tails / noOfTimes * 100;  // calculates percentage for tails
                double heads_percentage = (double)heads / noOfTimes * 100;  // calculates percentage for heads 
                Console.WriteLine("percentage of tails {0}%", tails_percentage);
                Console.WriteLine("percentage of heads {0}%", heads_percentage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************LeapYear*************************/

        /// <summary>
        /// To check year is a Leap year or not
        /// </summary>
        /// <param name="year">year as a parameter</param>
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

        /// <summary>
        /// number to the Power of two
        /// </summary>
        /// <param name="number">The number parameter</param>
        public static void PowerOftwo(double number)
        {
            try
            {
                double power = 0, i;
                for (i = 0; i <= number; i++)
                {
                    if (number < 31)
                    {
                        power = Math.Pow(2, number);
                    }
                }

                Console.WriteLine("2^number is {0}", power);
                if (number > 31)
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

        /// <summary>
        /// Find nth harmonic number
        /// </summary>
        /// <param name="number">The number parameter</param>
        public static void Harmonic(double number)
        {
            try
            {
                double sum = 0;
                for (int i = 1; i <= number; i++)
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

        /// <summary>
        /// To find Prime factor
        /// </summary>
        /// <param name="number">The number as a parameter</param>
        public static void Primefactor(int number)
        {
            try
            {
                Console.WriteLine("prime factors:");
                while (number % 2 == 0)
                {
                    Console.WriteLine("2");
                    number = number / 2;
                }

                for (int i = 3; i * i <= number; i += 3)
                {
                    while (number % 2 == 0)
                    {
                        // then prints value of i
                        Console.WriteLine("{0} ", i);
                        number = number / i;
                    }
                }

                if (number > 2)
                {
                    Console.WriteLine("{0}", number);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************Gambler*************************/

        /// <summary>
        /// To find the Gambler number
        /// </summary>
        /// <param name="stake">The $stake parameter</param>
        /// <param name="goal">The goal parameter</param>
        /// <param name="number">The number parameter</param>
        public static void Gamblernumber(int stake, int goal, int number)
        {
            try
            {
                int bets = 0, wins = 0;
                Random ran = new Random();
                double variable = 0.0;
                for (int i = 0; i < number; i++)
                {
                    int cash = stake;
                    while (cash > 0 && cash < goal)
                    {
                        bets++;
                        variable = ran.NextDouble();
                        if (variable < 0.5)
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
                int loss = number - wins;
                Console.WriteLine("wins ={0}", wins);
                Console.WriteLine("loss ={0}", loss);
                double winPercentage = wins * 100 / number;
                double lossPercentage = loss * 100 / number;
                Console.WriteLine("percentage of number of win = {0}%", winPercentage);     // Calulate the percentage of Win
                Console.WriteLine("percentage of number of loss = {0}%", lossPercentage);   // Calulate the percentage of loss
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************CouponNumbers*************************/

        /// <summary>
        /// To find coupon numbers
        /// </summary>
        /// <param name="number">The number parameter</param>
        public static void GetCoupon(int number)
        {
            try
            {
                int[] getCoupon = new int[number];
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
                        if (getCoupon[j] == result)
                        {
                            check = 1;
                        }
                    }

                    if (check == 0)
                    {
                        getCoupon[i] = result;
                        i++;
                    }
                }

                int print = count - check;
                Console.WriteLine("count the elements = {0}", print);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************2DArray*************************/

        /// <summary>
        /// Two dimension array
        /// </summary>
        /// <param name="row">The row parameter</param>
        /// <param name="column">The column parameter</param>
        public static void Parameter(int row, int column)
        {
            try
            {
                int[,] mdarray = new int[row, column];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
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
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write(mdarray[i, j] + " ");
                    }
                }

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************Sum of three Integer adds to ZERO*************************/

        /// <summary>
        /// Sum of three Integer adds to ZERO
        /// </summary>
        /// <param name="array">The array parameter</param>
        /// <param name="number">The number parameter</param>
        public static void Integer(int[] array, int number)
        {
            try
            {
                for (int i = 0; i < number - 2; i++)
                {
                    for (int j = i + 1; j < number - 1; j++)
                    {
                        for (int k = j + 1; k < number; k++)
                        {
                            if (array[i] + array[j] + array[k] == 0)
                            {
                                Console.WriteLine("{0},{1},{2}", array[i], array[j], array[k]);
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

        /// <summary>
        /// To find Distance between two points
        /// </summary>
        /// <param name="x">It takes x as a source parameter</param>
        /// <param name="y">It takes y as a destination parameter</param>
        public static void Distance(int x, int y)
        {
            try
            {
                double a = (double)Math.Pow(x, 2);
                double b = (double)Math.Pow(y, 2);
                double dist = (double)Math.Sqrt(a + b);
                Console.WriteLine("The distance between x and y is {0}\n", dist);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************Print all Permutation*************************/

        /// <summary>
        /// To print all permutation 
        /// </summary>
        /// <param name="str">user input string paramter</param>
        /// <param name="l">left parameter</param>
        /// <param name="r">right parameter</param>
        public static void Permute(string str, int l, int r)
        {
            try
            {
                if (l == r)
                {
                    Console.WriteLine(str);
                }
                else
                {
                    for (int i = l; i <= r; i++)
                    {
                        str = Swap(str, l, i);
                        Permute(str, l + 1, r);
                        str = Swap(str, l, i);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /* 
        * Swap Characters at position 
        * param a string value 
        * param i position 1 
        * param j position 2 
        * return swapped string 
        */

        /// <summary>
        /// Method to swap the array elements
        /// </summary>
        /// <param name="a">input string as a parameter</param>
        /// <param name="i">integer i as a parameter</param>
        /// <param name="j">integer j as a parameter</param>
        /// <returns>Swap</returns>
        public static string Swap(string a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }

        /******************StopWatch*************************/

        /// <summary>
        /// To check the elapse of time
        /// </summary>
        /// <param name="start">It takes start as a parameter</param>
        /// <param name="end">It takes end as a parameter</param>
        public static void Stopwatch(int start, int end)
        {
            try
            {
                long elapse = end - start;
                Console.WriteLine("Elapse time = {0}", elapse);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************TIC_TAC_TOE*************************/

        /// <summary>
        /// TIC_TAC_TOE game 
        /// </summary>
        /// <param name="array">array as a parameter</param>
        /// <param name="player">player as a integer parameter</param>
        /// <param name="choice">choice as a integer parameter</param>
        /// <param name="flag">flag as a integer parameter</param>
        public static void Game(char[] array, int player, int choice, int flag)
        {
            try
            {
                do
                {
                    Console.Clear(); //// whenever loop will be again start then screen will be clear  
                    Console.WriteLine("Player1:X and Player2:O");
                    Console.WriteLine("\n");
                    //// checking the chance of the player
                    if (player % 2 == 0)   
                    {
                        Console.WriteLine("Player 2 Chance");
                    }
                    else
                    {
                        Console.WriteLine("Player 1 Chance");
                    }

                    Console.WriteLine("\n");
                    Board(array); //// calling the board Function 
                    choice = int.Parse(Console.ReadLine()); //// Taking users choice  

                    //// checking that position where user want to run is marked (with X or O) or not  
                    if (array[choice] != 'X' && array[choice] != 'O')
                    {
                        if (player % 2 == 0)  
                        {
                            array[choice] = 'O';
                            player++;
                        }
                        else
                        {
                            array[choice] = 'X';
                            player++;
                        }
                    }
                    else  
                    {
                        Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, array[choice]);
                        Console.WriteLine("\n");
                        Console.WriteLine("Please wait 2 second board is loading again.....");
                        Thread.Sleep(2000);
                    }

                    flag = CheckWin(array); //// calling of check win  
                }
                while (flag != 1 && flag != -1); //// This loof will be run until all cell of the grid is not marked with X and O or some player is not win

                Console.Clear(); //// clearing the console  
                Board(array); //// getting filled board again  
                if (flag == 1) 
                {
                    Console.WriteLine("Player {0} has won", (player % 2) + 1);
                }
                else
                {
                    Console.WriteLine("Draw");
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        /// <summary>
        /// Method to print the board
        /// </summary>
        /// <param name="array">array as a parameter</param>
        public static void Board(char[] array)
        {
            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", array[1], array[2], array[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", array[4], array[5], array[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", array[7], array[8], array[9]);

            Console.WriteLine("     |     |      ");
        }

        /// <summary>
        /// Method to Check who won the game
        /// </summary>
        /// <param name="array">array as a parameter</param>
        /// <returns>CheckWin</returns>
        public static int CheckWin(char[] array)
        {
            //// Winning Condition For First Row  
            if (array[1] == array[2] && array[2] == array[3])
            {
                return 1;
            }
            else if (array[4] == array[5] && array[5] == array[6])
            {
                return 1;
            }
            else if (array[6] == array[7] && array[7] == array[8])
            {
                return 1;
            }
            else if (array[1] == array[4] && array[4] == array[7])
            {
                return 1;
            }
            else if (array[2] == array[5] && array[5] == array[8])
            {
                return 1;
            }
            else if (array[3] == array[6] && array[6] == array[9])
            {
                return 1;
            }
            else if (array[1] == array[5] && array[5] == array[9])
            {
                return 1;
            }
            else if (array[3] == array[5] && array[5] == array[7])
            {
                return 1;
            }
            else if (array[1] != '1' && array[2] != '2' && array[3] != '3' && array[4] != '4' && array[5] != '5' && array[6] != '6' && array[7] != '7' && array[8] != '8' && array[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        /******************QuadraticEquation*************************/

        /// <summary>
        /// To find QuadraticEquation
        /// </summary>
        /// <param name="a">a as a integer parameter</param>
        /// <param name="b">b as a integer parameter</param>
        /// <param name="c">c as a integer parameter</param>
        public static void Quadratic(int a, int b, int c)
        {
            try
            {
                double d, x1, x2;
                d = (b * b) - (4 * a * c);
                if (d == 0)
                {
                    Console.Write("Both roots are equal.\n");
                    x1 = -b / (2.0 * a);
                    x2 = x1;
                    Console.Write("First Root1= {0}\n", x1);
                    Console.Write("Second Root2= {0}\n", x2);
                }
                else if (d > 0)
                {
                    Console.Write("Both roots are real and diff-2\n");
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.Write("First Root1= {0}\n", x1);
                    Console.Write("Second Root2= {0}\n", x2);
                }
                else
                {
                    Console.Write("Root are imaginary:\nNo Solution. \n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************WindChill*************************/

        /// <summary>
        /// To calculate WindChill
        /// </summary>
        /// <param name="t">t as a temperature parameter</param>
        /// <param name="v">v as a speed parameter</param>
        public static void Chill(double t, double v)
        {
            try
            {
                double wind = 35.74 + (0.6215 * t) + (0.4275 * (t - 35.75) * Math.Pow(v, 0.16));
                if (t > 150)  
                {
                    Console.WriteLine("Temperature should be below 150");
                }
                else if ((v < 3) || (v > 120))
                {
                    Console.WriteLine("Speed should be between 3 to 120");
                }
                else
                {
                    Console.WriteLine(" The Wind Chill {0}", wind);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}  