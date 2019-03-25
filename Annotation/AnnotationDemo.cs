//-----------------------------------------------------------------------
// <copyright file="AnnotationDemo.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.Annotation
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Main Class for annotation
    /// </summary>
    public class AnnotationDemo
    {
        /// <summary>
        /// Mains the annotation.
        /// </summary>
        public static void MainAnnotation()
        {
            try
            {
                //// Object created
                Customer customer = new Customer
                {
                    Id = 12,
                    Name = "Krishna",
                    Address = "Kalburgi-585103"
                };

                //// Context 
                var context = new ValidationContext(customer, null, null);
                //// ValidationResult
                var result = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(customer, context, result, true);

                //// Loops over the result
                foreach (var message in result)
                {
                    ////Printing the Error Messages
                    Console.WriteLine(message.ErrorMessage);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
