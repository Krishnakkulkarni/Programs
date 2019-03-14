//-----------------------------------------------------------------------
// <copyright file="InventoryModel.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.InventoryManager
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class for Inventory Model
    /// </summary>
    public class InventoryModel
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The price
        /// </summary>
        private double price;

        /// <summary>
        /// The weight
        /// </summary>
        private double weight;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get => this.name; set => this.name = value; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public double Price { get => this.price; set => this.price = value; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double Weight { get => this.weight; set => this.weight = value; }
    }
}
