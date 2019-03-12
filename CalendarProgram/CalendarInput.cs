//-----------------------------------------------------------------------
// <copyright file="CalendarInput.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DataStructurePrograms.CalendarProgram
{
    using System;

    /// <summary>
    /// Takes input 
    /// </summary>
    public class CalendarInput
    {
        /// <summary>
        /// Starts the calendar.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <exception cref="Exception">throws exception</exception>
        public static void Temp(string[] args)
        {
            try
            {
                int year = 0;
                int month = 0;

                //// checks the number of Arguments passed by user
                if (args.Length != 2)
                {
                    Console.WriteLine("Please Enter the month and Year correctly in MM/YYYY");
                    Console.Read();
                    return;
                }

                if (UtilityClass.IsNumber(args[0]) == false)
                {
                    Console.WriteLine("Invalid Month");
                    Console.Read();
                    return;
                }

                month = Convert.ToInt32(args[0]);
                if (month <= 0 || month > 12)
                {
                    Console.WriteLine("Invalid Month");
                    Console.Read();
                    return;
                }

                if (UtilityClass.IsNumber(args[1]) == false)
                {
                    Console.WriteLine("Invalid year");
                    Console.Read();
                    return;
                }

                if (args[1].Length < 4)
                {
                    Console.WriteLine("Wrong Year specified");
                    Console.Read();
                    return;
                }

                year = Convert.ToInt32(args[1]);

                Calendar.PrintCalendar(month, year);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}