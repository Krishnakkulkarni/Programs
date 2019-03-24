//-----------------------------------------------------------------------
// <copyright file="ProxyClass.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.StructuralDesignPattern.Proxy
{
    using System;

    /// <summary>
    /// Entry point
    /// </summary>
    public class ProxyClass
    {
        /// <summary>
        /// Proxies this instance.
        /// </summary>
        public static void Proxy()
        {
            ProxyClient proxy = new ProxyClient();
            Console.WriteLine("Data from Proxy Client = {0}", proxy.GetData());

            Console.ReadKey();
        }
    }
}
