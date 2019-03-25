//-----------------------------------------------------------------------
// <copyright file="Scooter.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.CreationalDesignPattern.FactoryPattern
{
    using System;

    /// <summary>
    /// The Scooter class
    /// </summary>
    public class Scooter : IFactory
    {
        /// <summary>
        /// Drives the specified miles.
        /// </summary>
        /// <param name="miles">The miles.</param>
        public void Drive(int miles)
        {
            try
            {
                Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
