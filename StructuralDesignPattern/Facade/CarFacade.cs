//-----------------------------------------------------------------------
// <copyright file="CarFacade.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.StructuralDesignPattern.Facade
{
    using System;

    /// <summary>
    /// The Facade class
    /// </summary>
    public class CarFacade
    {
        /// <summary>
        /// Instance of model
        /// </summary>
        private readonly CarModel model;

        /// <summary>
        /// Instance of engine
        /// </summary>
        private readonly CarEngine engine;

        /// <summary>
        /// Instance of body
        /// </summary>
        private readonly CarBody body;

        /// <summary>
        /// Instance of accessories
        /// </summary>
        private readonly CarAccessories accessories;

        /// <summary>
        /// Initializes a new instance of the <see cref="CarFacade"/> class.
        /// </summary>
        public CarFacade()
        {
            this.model = new CarModel();
            this.engine = new CarEngine();
            this.body = new CarBody();
            this.accessories = new CarAccessories();
        }

        /// <summary>
        /// Creates the complete car.
        /// </summary>
        public void CreateCompleteCar()
        {
            try
            {
                Console.WriteLine("Creating a Car \n");
                this.model.SetModel();
                this.engine.SetEngine();
                this.body.SetBody();
                this.accessories.SetAccessories();
                Console.WriteLine("\n Car creation complete :");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
