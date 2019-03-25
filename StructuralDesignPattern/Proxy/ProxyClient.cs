//-----------------------------------------------------------------------
// <copyright file="ProxyClient.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.StructuralDesignPattern.Proxy
{ 
    using System;

    /// <summary>
    /// The 'Proxy Object' class
    /// </summary>
    public class ProxyClient : IClient
    {
        /// <summary>
        /// Instance of RealClient
        /// </summary>
        private readonly RealClient client = new RealClient();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyClient"/> class.
        /// </summary>
        public ProxyClient()
        {
            Console.WriteLine("ProxyClient: Initialized");
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns>returns list of string</returns>
        public string GetData()
        {
            try
            {
            return this.client.GetData();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
