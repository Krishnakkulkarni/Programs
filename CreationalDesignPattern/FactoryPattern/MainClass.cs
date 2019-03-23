//-----------------------------------------------------------------------
// <copyright file="MainClass.cs" company="Bridgelabz">
//     Company @ 2018 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DesigenPattern.CreationalDesignPattern.FactoryPattern
{
    using System;

    /// <summary>
    /// Main class
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args">args as a parameter</param>
        public static void Main(string[] args)
        {
            try
            {
                VehicleFactory factory = new Factoryvehicle();

                IFactory honda = factory.Getvehicle("Honda");
                honda.Ride(10);

                IFactory yahama = factory.Getvehicle("Yamaha"); 
                yahama.Ride(20);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
