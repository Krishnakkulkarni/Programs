//-----------------------------------------------------------------------
// <copyright file="Utilityclass.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
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
    /// Core class
    /// </summary>
    public class Utilityclass
    {
        /******************Anagram*************************/

        /// <summary>
        /// Comparing two string using detection method
        /// </summary>
        /// <param name="word1">First string.</param>
        /// <param name="word2">Second string.</param>
        public static void Detection(string word1, string word2)
        {
            try
            {
                char[] char1 = word1.ToCharArray();
                char[] char2 = word2.ToCharArray();
                Array.Sort(char1);
                Array.Sort(char2);
                string newWord1 = new string(char1);
                string newWord2 = new string(char2);

                //// ToLower allows to compare the words in same case, in this case, lower case.  
                //// ToUpper will also do exact same thing in this context  
                if (newWord1 == newWord2)
                {
                    Console.WriteLine("Yes! Words \"{0}\" and \"{1}\" are Anagrams", word1, word2);
                }
                else
                {
                    Console.WriteLine("No! Words \"{0}\" and \"{1}\" are not Anagrams", word1, word2);
                }

                //// Hold Console screen alive to view the results.  
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************PrimeNumbers*************************/

            /// <summary>
            /// Method to take input to check prime number
            /// </summary>
            /// <param name="number">Input parameter.</param>
        public static void Prime(int number)
        {
            try
            {
                int k = 0;
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        k++;
                    }
                }

                if (k == 2)
                {
                    Console.WriteLine("Entered Number is a Prime Number {0}", number);
                }
                else
                {
                    Console.WriteLine("Not a Prime Number");
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************PrimeNumbers that are Anagram and Palindrome*************************/

        /// <summary>
        /// check prime numbers that are Anagram and Palindrome
        /// </summary>
        /// <param name="number">It accept the parameter of number.</param>
        public static void PrintPrimePalindrome(int number)
        {
            try
            {   
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************To search and Sort the elements*************************/

        /***************************i. Binary Search for integer ***************************/

        /// <summary>
        /// Binary search.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="search">search element.</param>
        /// <returns>returns index value</returns>
        public static int BinarySearch(int[] item, int search)
        {
            try
            {
                int low = 0, high = item.Length, mid = 0;
                while (low <= high)
                {
                    mid = low + ((high - low) / 2);
                    if (item[mid] == search)
                    {
                        return mid;
                    }
                    else if (item[mid] < search)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return -1;
        }

        /***************************ii. Binary Search for String ***************************/

        /// <summary>
        /// Binary search.
        /// </summary>
        /// <param name="element">element as a parameter</param>
        /// <param name="s">string s as a parameter</param>
        /// <returns>returns index value</returns>
        public static int BinarySearch(string[] element, string s)
        {
            try
            {
                int low = 0, high = element.Length - 1, mid = 0;
                while (low <= high)
                {
                    mid = low + ((high - low) / 2);
                    int res = s.CompareTo(element[mid]);
                    if (res == 0)
                    {
                        return mid;
                    }
                    else if (res > 0)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return -1;
        }

        /***************************iii. Insertion Sort for integer ***************************/

        /// <summary>
        /// Insertions sort.
        /// </summary>
        /// <param name="element">element as a parameter</param>
        public static void InsertionSort(int[] element)
        {
            try
            {
                int temp, j;
                for (int i = 1; i < element.Length; i++)
                {
                    temp = element[i];
                    j = i;
                    while (j > 0 && element[j - 1] > temp)
                    {
                        element[j] = element[j - 1];
                        j = j - 1;
                    }

                    element[j] = temp;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /***************************iv. Insertion sort for String ***************************/

        /// <summary>
        /// Insertion sort.
        /// </summary>
        /// <param name="element">element as a parameter</param>
        public static void InsertionSort(IComparable[] element)
        {
            try
            {
                int i, j;
                for (i = 1; i < element.Length; i++)
                {
                    IComparable value = element[i];
                    j = i - 1;
                    while (j >= 0 && element[j].CompareTo(value) > 0)
                    {
                        element[j + 1] = element[j];
                        j--;
                    }

                    element[j + 1] = value;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /***************************v. Bubble sort for integer ***************************/

        /// <summary>
        /// Bubbles sort
        /// </summary>
        /// <param name="element">elements</param>
        public static void Bubblesort(int[] element)
        {
            try
            {
                int n = element.Length;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (element[j] > element[j + 1])
                        {
                            int temp = element[j];
                            element[j] = element[j + 1];
                            element[j + 1] = temp;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /***************************vi. Binary Search for string ***************************/

        /// <summary>
        /// Bubble sort.
        /// </summary>
        /// <param name="value">The values.</param>
        public static void Bubblesort(string[] value)
        {
            try
            {
                int n = value.Length;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (value[j].CompareTo(value[j + 1]) > 0)
                        {
                            string temp = value[j];
                            value[j] = value[j + 1];
                            value[j + 1] = temp;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        /******************FindYourOwnNumber*************************/

        /// <summary>
        ///  Method to find your number
        /// </summary>
        /// <param name="array">using array as a parameter</param>
        public static void TryYournumber(int[] array)
        {
            try
            {
                int low = 0, high = array.Length;
                int mid = (low + high) / 2;
                while (low < high)
                {
                    Console.WriteLine(mid);
                    int ch = Convert.ToInt32(Console.ReadLine());
                    if (ch == 1)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }

                    mid = (low + high) / 2;
                }

                Console.WriteLine(low);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************Search word from file*************************/

            /// <summary>
            /// Search Word from the file
            /// </summary>
            /// <param name="line">line as a parameter</param>
            /// <param name="key">key as a parameter</param>
        public static void SearchWord(string line, string key)
        {
            try
            {
                string[] words = line.Split(',');
                int count = 0;
                for (int i = 0; i < words.Length; i++)
                {
                    if (key.Equals(words[i]))
                    {
                        Console.WriteLine("the {0} word found in a list", words[i]);
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("The word not found");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************InsertionSort*************************/

        /// <summary>
        /// Method to Print the array elements
        /// </summary>
        /// <param name="array">It takes array elements as input</param>
        public static void PrintArray(int[] array)
        {
            try
            {
                int number = array.Length;
                for (int i = 0; i < number; ++i)
                {
                    Console.Write(" The sorted array elements are\n " + array[i]);
                }

                Console.Write("\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Method to sort the numbers using InsertionSort.
        /// </summary>
        /// <param name="array">Input parameter as array</param>
        public static void Sort(int[] array)
        {
            try
            {
                int number = array.Length;
                for (int i = 1; i < number; i++)
                {
                    int key = array[i];
                    int j = i - 1;

                    // Move elements of arr[0...i-1], 
                    // that are greater than key,  
                    // to one position ahead of 
                    // their current position 
                    while (j >= 0 && array[j] > key)
                    {
                        array[j + 1] = array[j];
                        j = j - 1;
                    }

                    array[j + 1] = key;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************BubbleSort*************************/

            /// <summary>
            /// Method to sort the elements using Bubble sort
            /// </summary>
            /// <param name="array">array as a parameter</param>
        public static void BubbleSort(int[] array)
        {
            try
            {
                int number = array.Length;
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j < number - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Print the Bubble sort elements
        /// </summary>
        /// <param name="name">name as a parameter</param>
        public static void BubbleSort(string[] name)
        {
            try
            {
                int number = name.Length;
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j < number - i - 1; j++)
                    {
                        if (name[j].CompareTo(name[j + 1]) > 0)
                        {
                            string temp = name[j];
                            name[j] = name[j + 1];
                            name[j + 1] = temp;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************MergeSort*************************/

        /// <summary>
        /// Sort the elements using MergeSort technique
        /// </summary>
        /// <param name="s">string s as a parameter</param>
        /// <returns>input</returns>
        public static int Input(string s)
        {
            try
            {
                Console.WriteLine(s);
                //// string strInput = Console.ReadLine();
                int intinput = Convert.ToInt32(Console.ReadLine());
                return intinput;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Method to read array elements
        /// </summary>
        /// <param name="a">a is a parameter</param>
        /// <param name="capacity">capacity as a parameter</param>
        public static void ReadIntArray(int[] a, int capacity)
        {
            try
            {
                for (int i = 0; i < capacity; i++)
                {
                    a[i] = Input("Enter element (" + (i + 1) + ") : ");
                }
            }
            catch (NumberFormatException e)                                        
            {
                Console.WriteLine("enter elements in integers... Try again!\n");
                ReadIntArray(a, capacity);
                Console.WriteLine(e.Message);
            }
            catch (Exception e)                                                     
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************DayOfWeek*************************/

        /// <summary>
        /// To find a day from a week
        /// </summary>
        /// <param name="day">day as a parameter</param>
        /// <param name="month">month as a parameter</param>
        /// <param name="year">year as a parameter</param>
        public static void DayOfWeek(int day, int month, int year)
        {
            try
            {
                int y0 = (year - (14 - month)) / 12;
                int x = (y0 + y0) / (4 - y0) / (100 + y0) / 400;
                int m0 = (month + 12) * (((14 - month) / 12) - 2);
                int d0 = (day + x + (31 * m0 / 12)) % 7;
                Console.WriteLine(d0 + 1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************VendingMachine*************************/

            /// <summary>
            /// To find the how many notes are there.
            /// </summary>
            /// <param name="amount">amount as a parameter</param>
        public static void VendingMachine(int amount)
        {
            try
            {
                int note1000 = 0, note500 = 0, note100 = 0, note50 = 0, note20 = 0, note10 = 0, note5 = 0, note2 = 0, note1 = 0;

                if (amount >= 1000)
                {
                    note1000 = amount / 1000;
                    amount = amount - (note1000 * 1000);
                }

                if (amount >= 500)
                {
                    note500 = amount / 500;
                    amount = amount - (note500 * 500);
                }

                if (amount >= 100)
                {
                    note100 = amount / 100;
                    amount = amount - (note100 * 100);
                }

                if (amount >= 50)
                {
                    note50 = amount / 50;
                    amount = amount - (note50 * 50);
                }

                if (amount >= 20)
                {
                    note20 = amount / 20;
                    amount = amount - (note20 * 20);
                }

                if (amount >= 10)
                {
                    note10 = amount / 10;
                    amount = amount - (note10 * 10);
                }

                if (amount >= 5)
                {
                    note5 = amount / 5;
                    amount = amount - (note5 * 5);
                }

                if (amount >= 2)
                {
                    note2 = amount / 2;
                    amount = amount - (note2 * 2);
                }

                if (amount >= 1)
                {
                    note1 = amount / 2;
                    amount = amount - (note1 * 1);
                }

                Console.WriteLine("Amount to be Paid ");
                Console.WriteLine("1000=" + note1000);
                Console.WriteLine("500=" + note500);
                Console.WriteLine("100=" + note100);
                Console.WriteLine("50=" + note50);
                Console.WriteLine("20=" + note20);
                Console.WriteLine("10=" + note10);
                Console.WriteLine("5=" + note5);
                Console.WriteLine("2=" + note2);
                Console.WriteLine("1=" + note1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************TemparetureConversion*************************/

        /// <summary>
        /// To find Celsius to Fahrenheit and Fahrenheit to Celsius
        /// </summary>
        /// <param name="temperature">temperature as a parameter</param>
        /// <param name="unit">unit as a parameter</param>
        public static void TemparetureConversion(int temperature, char unit)
        {
            try
            {
                if (unit != 'f' || unit != 'F')
                {
                    Console.WriteLine("Tempareture in Celsius to Fahrenheit = {0}", (temperature * 9 / 5) + 32);
                }
                else if (unit != 'c' || unit != 'C')
                {
                    Console.WriteLine("Tempareture in Fahrenheit to Celsius = {0}", (temperature - 32) * 5 / 9);
                }
                else
                {
                    Console.WriteLine("Please enter valid value ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************MonthlyPayment*************************/

        /// <summary>
        /// To find the MonthlyPayment
        /// </summary>
        /// <param name="year">year as a parameter</param>
        /// <param name="principal">principal as a parameter</param>
        /// <param name="percent">percent as a parameter</param>
        public static void MonthlyPayment(double year, double principal, double percent)
        {
            try
            {
                double number = 12 * year;
                double result = percent / (12 * 100);
                double payment = principal * percent / (1 - Math.Pow(1 + percent, -number));
                //// Console.WriteLine(" = {0}",Result);
                Console.WriteLine("Monthly payment is = {0}", payment);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************Squareroot*************************/

        /// <summary>
        /// To find the Square Root
        /// </summary>
        /// <param name="c">c as a parameter</param>
        public static void Squareroot(int c)
        {
            try
            {
                double t = c;
                double epsilon = 1e-15;
                while (Math.Abs(t - (c / t)) > (epsilon * t))
                {
                    t = c / (t + t) / 2;
                }

                Console.WriteLine(t);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /******************Converting to binary*************************/

        /// <summary>
        /// Converting decimal to binary
        /// </summary>
        /// <param name="input">Input as a input parameter</param>
        /// <returns>boolean IsNumber</returns>
        public static bool IsNumber(string input)
        {
            try
            {
                if (input.Trim().Equals(string.Empty))
                {
                    return false;
                }

                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsDigit(input[i]) == false)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /******************SwapNibbles*************************/

            /// <summary>
            /// Converting integer to binary
            /// </summary>
            /// <param name="number">number as a parameter</param>
            /// <returns>Array integer</returns>
        public static int[] NibblesSwap(int number)
        {
            try
            {
                int[] binarynumber = new int[10];
                int i = 0;
                while (number > 0)
                {
                    binarynumber[i] = number % 2;
                    number = number / 2;
                    i++;
                }

                for (i = 1; i >= 0; i++)
                {
                    i = i - 1;

                    Console.Write("{0}", binarynumber[i]);
                }

                return binarynumber;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Method to take array elements
        /// </summary>
        /// <param name="binary">binary array</param>
        /// <returns>Decimal</returns>
        public static int ToDecimal(int[] binary)
        {
            try
            {
                int decimalnumber = 0, j = 0;
                for (int i = binary.Length - 1; i >= 0; i++)
                {
                    if (binary[i] == 1)
                    {
                        decimalnumber = decimalnumber + (int)Math.Pow(2, j);
                    }

                    j++;
                }

                return decimalnumber;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Method to take array elements
        /// </summary>
        /// <param name="binary">binary array</param>
        /// <returns>NibblesSwap</returns>
        public static int[] NibblesSwap(int[] binary)
        {
            try
            {
                int temporary, j;
                j = binary.Length - 4;
                for (int i = 0; i < 4; i++)
                {
                    temporary = binary[i];
                    binary[i] = binary[j];
                    binary[j] = temporary;
                    j++;
                }

                return binary;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Method to take array elements
        /// </summary>
        /// <param name="binary">binary array</param>
        public static void Display(int[] binary)
        {
            for (int i = 0; i < binary.Length; i++)
            {
                Console.WriteLine(binary[i]);
            }
        }
    }
}