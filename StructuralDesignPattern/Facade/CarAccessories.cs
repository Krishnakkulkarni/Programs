//-----------------------------------------------------------------------
// <copyright file="CarAccessories.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.StructuralDesignPattern.Facade
{
    using System;

    /// <summary>
    /// The 'Subsystem ClassD' class
    /// </summary>
    public class CarAccessories
    {
        /// <summary>
        /// Sets the accessories.
        /// </summary>
        public void SetAccessories()
        {
            try
            {
                Console.WriteLine(" CarAccessories - SetAccessories");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
