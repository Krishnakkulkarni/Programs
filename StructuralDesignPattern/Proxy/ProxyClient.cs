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
        RealClient client = new RealClient();
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
        /// <returns></returns>
        public string GetData()
        {
            return client.GetData();
        }
    }
}
