//-----------------------------------------------------------------------
// <copyright file="RealClient.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.StructuralDesignPattern.Proxy
{
    using System;

    /// <summary>
    /// Real client class which implements IClient interface
    /// </summary>
    /// <seealso cref="DesignPatternProgram.StructuralDesignPattern.Proxy.IClient" />
    public class RealClient : IClient
    {
        string Data;
        /// <summary>
        /// Initializes a new instance of the <see cref="RealClient"/> class.
        /// </summary>
        public RealClient()
        {
            Console.WriteLine("Real Client: Initialized");
            Data1 = "Local Machine";
        }

        /// <summary>
        /// Gets or sets the data1.
        /// </summary>
        /// <value>
        /// The data1.
        /// </value>
        public string Data1 { get => Data; set => Data = value; }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        public string GetData()
        {
            return Data1;
        }
    }
}
