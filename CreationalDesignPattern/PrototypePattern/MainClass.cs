//-----------------------------------------------------------------------
// <copyright file="MainClass.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPatternProgram.CreationalDesignPattern.PrototypePattern
{
    using System;
    using DesignPatternProgram.CreationalDesignPattern.Prototype;

    /// <summary>
    /// Main class
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// Entry point of the program
        /// </summary>
        /// <param name="args">args as a parameter</param>
        public static void Main(string[] args)
        {
            Developer dev = new Developer
            {
                Name = "Krishna",
                Role = "devloper",
                PreferredLanguage = "C#"
            };

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "venkat"; //// Not mention Role and PreferredLanguage, it will copy above

            Console.WriteLine(dev.GetDetails());
            Console.WriteLine(devCopy.GetDetails());

            Devops devops = new Devops
            {
                Name = "maruti",
                Role = "devops",
                WordsPerMinute = 120
            };

            Devops devopsCopy = (Devops)devops.Clone();
            devopsCopy.Name = "murli";
            devopsCopy.WordsPerMinute = 115; //// Not mention Role, it will copy above

            Console.WriteLine(devops.GetDetails());
            Console.WriteLine(devopsCopy.GetDetails());

            Console.ReadKey();
        }
    }
}
