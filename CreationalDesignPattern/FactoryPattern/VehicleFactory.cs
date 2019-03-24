//-----------------------------------------------------------------------
// <copyright file="VehicleFactory.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.CreationalDesignPattern.FactoryPattern
{
    using System;

    /// <summary>
    /// The Vehicle factory abstract class
    /// </summary>
    public abstract class VehicleFactory
    {
        /// <summary>
        /// Gets the vehicle.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        /// <returns>returns vehicle</returns>
        public abstract IFactory GetVehicle(string vehicle);
    }
}
