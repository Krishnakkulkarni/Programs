//-----------------------------------------------------------------------
// <copyright file="IClient.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.StructuralDesignPattern.Proxy
{
    using System;

    /// <summary>
    /// IClient interface
    /// </summary>
    public interface IClient
    {
        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        string GetData();
    }
}
