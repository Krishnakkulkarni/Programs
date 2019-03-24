//-----------------------------------------------------------------------
// <copyright file="FacadeClass.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.StructuralDesignPattern.Facade
{
    using System;

    /// <summary>
    /// Entry point
    /// </summary>
    class FacadeClass
    {
        /// <summary>
        /// Facades this instance.
        /// </summary>
        public static void Facade()
        {
            CarFacade facade = new CarFacade();

            facade.CreateCompleteCar();

            Console.ReadKey();
        }
    }
}
