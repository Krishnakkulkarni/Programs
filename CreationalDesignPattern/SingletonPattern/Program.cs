//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//     Company @ 2018 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DesignPattern
{
    using System;
    using DesigenPattern.CreationalPattern;

    /// <summary>
    /// Main class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args">args as a parameter</param>
        public static void Main(string[] args)
        {
            try
            {
                Singleton employee = Singleton.GetInstance;
                employee.Print("Employee");

                Singleton student = Singleton.GetInstance;
                student.Print("Student");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
