//-----------------------------------------------------------------------
// <copyright file="PrototypeClass.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.CreationalDesignPattern.Prototype
{
    using System;

    /// <summary>
    /// Main class
    /// </summary>
    public class PrototypeClass
    {
        /// <summary>
        /// Prototype method
        /// </summary>
        public static void Prototype()
        {
            try
            {
                Developer dev = new Developer
                {
                    Name = "Rashmi",
                    Role = "Team Leader",
                    PreferredLanguage = "C#"
                };

                Developer devCopy = (Developer)dev.Clone();
                //// Not mention Role and PreferredLanguage, it will copy above
                devCopy.Name = "Komal";

                Console.WriteLine(dev.GetDetails());
                Console.WriteLine(devCopy.GetDetails());

                Typist typist = new Typist
                {
                    Name = "Mohan",
                    Role = "Typist",
                    WordsPerMinute = 120
                };

                Typist typistCopy = (Typist)typist.Clone();
                //// Not mention Role, it will copy above
                typistCopy.Name = "Sahil";
                typistCopy.WordsPerMinute = 115;

                Console.WriteLine(typist.GetDetails());
                Console.WriteLine(typistCopy.GetDetails());

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
