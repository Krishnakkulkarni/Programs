//-----------------------------------------------------------------------
// <copyright file="InventoryDetails.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.InventoryManager
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class for Inventory
    /// </summary>
    public class InventoryDetails
    {
        /// <summary>
        /// Gets or sets the rice.
        /// </summary>
        /// <value>
        /// The rice.
        /// </value>
        public List<InventoryModel> Rices { get; set; }

        /// <summary>
        /// Gets or sets the wheat.
        /// </summary>
        /// <value>
        /// The wheat.
        /// </value>
        public List<InventoryModel> Wheat { get; set; }

        /// <summary>
        /// Gets or sets the pulses.
        /// </summary>
        /// <value>
        /// The pulses.
        /// </value>
        public List<InventoryModel> Pulses { get; set; }
    }
}