//-----------------------------------------------------------------------
// <copyright file="NumberFormatException.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;
using System.Runtime.Serialization;
    
    /// <summary>
    /// Exception Handling
    /// </summary>
    internal class NumberFormatException : Exception
    {
        /// <summary>
        /// Constructor for number Exception
        /// </summary>
        public NumberFormatException()
        {
        }

        /// <summary>
        /// string Exception handling
        /// </summary>
        /// <param name="message">message as a parameter</param>
        public NumberFormatException(string message) : base(message)
        {
        }

        /// <summary>
        /// string with inner exception handling
        /// </summary>
        /// <param name="message">message as a parameter</param>
        /// <param name="innerException">innerException as a parameter</param>
        public NumberFormatException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// SerializationInfo exception
        /// </summary>
        /// <param name="info">info as a parameter</param>
        /// <param name="context">context as a parameter</param>
        protected NumberFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}