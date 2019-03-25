//-----------------------------------------------------------------------
// <copyright file="CarBody.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.StructuralDesignPattern.Facade
{
    using System;

    /// <summary>
    /// The Car body class
    /// </summary>
    public class CarBody
    {
        /// <summary>
        /// Sets the body.
        /// </summary>
        public void SetBody()
        {
            try
            {
                Console.WriteLine(" CarBody - SetBody");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
