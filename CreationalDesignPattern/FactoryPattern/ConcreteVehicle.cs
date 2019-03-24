//-----------------------------------------------------------------------
// <copyright file="ConcreteVehicle.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.CreationalDesignPattern
{
    using System;
    using DesignPattern.CreationalDesignPattern.FactoryPattern;

    /// <summary>
    /// Concrete vehicle class
    /// </summary>
    /// <seealso cref="DesignPattern.CreationalDesignPattern.FactoryPattern.VehicleFactory" />
    public class ConcreteVehicle : VehicleFactory
    {
        /// <summary>
        /// Gets the vehicle.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        /// <returns>returns object</returns>
        /// <exception cref="ApplicationException">generates exception</exception>
        public override IFactory GetVehicle(string vehicle)
        {
            switch (vehicle)
            {
                case "Scooter":
                    return new Scooter();
                  
                case "Bike":
                    return new Bike();
                    
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", vehicle));
            }
        }
    }
}
