//-----------------------------------------------------------------------
// <copyright file="SingletonClass.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.CreationalDesignPattern.SingletonLink
{
    using System;
    using static DesignPattern.CreationalDesignPattern.SingletonDemo;

    /// <summary>
    /// The singleton class
    /// </summary>
    public class SingletonClass
    {
        /// <summary>
        /// defines entry point
        /// </summary>
        /// <param name="args">string argument</param>
        public static void SingletonMain()
        {
            Singleton student1 = Singleton.GetInstance;
            student1.PrintDetails("1st Student");

            Singleton student2 = Singleton.GetInstance;
            student1.PrintDetails("2nd Student");
        }
    }
}
