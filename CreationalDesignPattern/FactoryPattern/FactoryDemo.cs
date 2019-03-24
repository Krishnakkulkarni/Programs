//-----------------------------------------------------------------------
// <copyright file="FactoryDemo.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.CreationalDesignPattern.FactoryPattern
{
    using System;

    /// <summary>
    /// Factory Demo Class
    /// </summary>
    public class FactoryDemo
    {
        /// <summary>
        /// Factories the main.
        /// </summary>
        public static void FactoryMain()
        {
            VehicleFactory vehical = new ConcreteVehicle();
            IFactory scooter = vehical.GetVehicle("Scooter");
            scooter.Drive(10);
            IFactory bike = vehical.GetVehicle("Bike");
            bike.Drive(20);
            Console.ReadKey();
        }
    }
}
