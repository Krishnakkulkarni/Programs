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
        /// <summary>
        /// Instance of data
        /// </summary>
        private string data;

        /// <summary>
        /// Initializes a new instance of the <see cref="RealClient"/> class.
        /// </summary>
        public RealClient()
        {
            Console.WriteLine("Real Client: Initialized");
            this.Data1 = "Local Machine";
        }

        /// <summary>
        /// Gets or sets the data1.
        /// </summary>
        /// <value>
        /// The data1.
        /// </value>
        public string Data1 { get => this.data; set => this.data = value; }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns>returns list of string</returns>
        public string GetData()
        {
            try
            {
                return this.Data1;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
