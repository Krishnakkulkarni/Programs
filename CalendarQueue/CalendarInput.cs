//-----------------------------------------------------------------------
// <copyright file="QueueCalendar.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DataStructurePrograms.CalendarQueue
{
    using System;

    /// <summary>
    /// Takes required input for this class
    /// </summary>
    public class CalendarInput
    {
        /// <summary>
        /// Starts the calendar.
        /// </summary>
        public static void CalendarStart()
        {
            try
            {
                int month = 0;
                int year = 0;

                bool loopForMonth = true; ////loops untill valid input for month is given
                while (loopForMonth)
                {
                    Console.WriteLine("Enter the month");
                    string stringMonth = Console.ReadLine();

                    if (Utility.IsNumber(stringMonth) == false)
                    {
                        Console.WriteLine("Invalid Month");

                        continue;
                    }

                    month = Convert.ToInt32(stringMonth);
                    if (month <= 0 || month > 12)
                    {
                        Console.WriteLine("Invalid Month");
                        continue;
                    }

                    loopForMonth = false;
                }

                bool loopForYear = true; ////loops untill valid input for year is given
                while (loopForYear)
                {
                    Console.WriteLine("Enter the year");
                    string stringYear = Console.ReadLine();

                    if (Utility.IsNumber(stringYear) == false)
                    {
                        Console.WriteLine("Invalid Month");

                        continue;
                    }

                    if (stringYear.Length < 4)
                    {
                        Console.WriteLine("Wrong Year specified");
                        Console.Read();
                        return;
                    }

                    year = Convert.ToInt32(stringYear);
                    loopForYear = false;
                }

                QueueCalendar.PrintCalendar(month, year);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
