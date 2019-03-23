//-----------------------------------------------------------------------
// <copyright file="IFactory.cs" company="Bridgelabz">
//     Company @ 2018 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DesigenPattern.CreationalDesignPattern.FactoryPattern
{
    using System;

    /// <summary>
    /// As a Interface 
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Method to pass km variable
        /// </summary>
        /// <param name="km">kilo meter</param>
        void Ride(int km);
    }

    /// <summary>
    /// Class to implement interface
    /// </summary>
    public class Honda : IFactory
    {
        /// <summary>
        /// Method overridden
        /// </summary>
        /// <param name="km">kilo meter</param>
        public void Ride(int km)
        {
            Console.WriteLine(" Ride of honda = " + km.ToString() + "km");
        }
    }

    /// <summary>
    /// Class to implement interface
    /// </summary>
    public class Yamaha : IFactory
    {
        /// <summary>
        /// Method overridden
        /// </summary>
        /// <param name="km">kilo meter</param>
        public void Ride(int km)
        {
            Console.WriteLine(" Ride of yahama = " + km.ToString() + "km");
        }
    }

    /// <summary>
    /// Abstract class
    /// </summary>
    public abstract class VehicleFactory
    {
        /// <summary>
        /// Method to return interface
        /// </summary>
        /// <param name="vehicle">vehicle  as a parameter</param>
        /// <returns>return interface</returns>
        public abstract IFactory Getvehicle(string vehicle);
    }

    /// <summary>
    /// Class to implement Abstract class
    /// </summary>
    public class Factoryvehicle : VehicleFactory
    {
        /// <summary>
        /// Method to return interface
        /// </summary>
        /// <param name="vehicle">vehicle as a parameter</param>
        /// <returns>return Get vehicle</returns>
        public override IFactory Getvehicle(string vehicle)
        {
            switch (vehicle)
            {
                case "Honda":
                    return new Honda();

                case "Yamaha":
                    return new Yamaha();

                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", vehicle));
            }
        }
    }
}