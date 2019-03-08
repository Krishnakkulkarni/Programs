//-----------------------------------------------------------------------
// <copyright file="StackCalendar.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DataStructurePrograms.CalendarStack
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /// <summary>
    /// Print calendar of given month and year
    /// </summary>
    public class StackCalendar
    {
        /// <summary>
        /// Prints the calendar.
        /// </summary>
        /// <param name="month">The month.</param>
        /// <param name="year">The year.</param>
        /// <exception cref="Exception">throws exception </exception>
        public static void PrintCalendar(int month, int year)
        {
            try
            {
                Stack stack = new Stack();
                stack.StackInitialise(200);
                string[] monthsArray = { string.Empty, "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                int[] numberOfDaysArray = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                ////to check if the given year is aleap year
                if (month == 2 && Utility.CheckLeapYear(year))
                {
                    numberOfDaysArray[month] = 29;
                }

                Console.WriteLine(monthsArray[month]);
                Console.WriteLine(year);
                Console.WriteLine(" S  M  T  W  TH  F  S");

                ////getting the first day of specified month and year
                int day = Utility.DayOfWeek(month, 1, year);

                for (int i = numberOfDaysArray[month]; i >= 0; i--)
                {
                    stack.Push(i);  //// pushing the data into the stack in the reverse order
                }

                for (int i = 0; i < day; i++)
                {
                    Console.Write("   ");
                }

                for (int i = 1; i <= numberOfDaysArray[month]; i++)
                {
                    if (i < 10)
                    {
                        Console.Write(" " + stack.Pop() + " ");  //// popping the date elements from the top data 
                    }

                    if (i > 9)
                    {
                        Console.Write(string.Empty + i + " ");
                    }

                    if ((i + day) % 7 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}