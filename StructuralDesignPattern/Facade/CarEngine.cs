//-----------------------------------------------------------------------
// <copyright file="CarEngine.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.StructuralDesignPattern.Facade
{
    using System;

    /// <summary>
    /// The Car Engine Class
    /// </summary>
    public class CarEngine
    {
        /// <summary>
        /// Sets the engine.
        /// </summary>
        public void SetEngine()
        {
            try
            {
                Console.WriteLine(" CarEngine - SetEngine");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
