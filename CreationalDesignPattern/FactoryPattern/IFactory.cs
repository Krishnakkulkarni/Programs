﻿//-----------------------------------------------------------------------
// <copyright file="IFactory.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.CreationalDesignPattern.FactoryPattern
{
    using System;

    /// <summary>
    /// IFactory interface
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Drives the specified miles.
        /// </summary>
        /// <param name="miles">The miles.</param>
        void Drive(int miles);
    }
}