//-----------------------------------------------------------------------
// <copyright file="CarModel.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.StructuralDesignPattern.Facade
{
    using System;

    /// <summary>
    /// Car Model class
    /// </summary>
    public class CarModel
    {
        /// <summary>
        /// Sets the model.
        /// </summary>
        public void SetModel()
        {
            try
            {
                Console.WriteLine(" CarModel - SetModel");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
