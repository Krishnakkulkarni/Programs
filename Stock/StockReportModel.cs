//-----------------------------------------------------------------------
// <copyright file="StockReportModel.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.Stock
{
    using System;

    /// <summary>
    /// Class for stock report model
    /// </summary>
    public class StockReportModel
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
        /// The share
        /// </summary>
        private double share;

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
        /// Gets or sets the share.
        /// </summary>
        /// <value>
        /// The share.
        /// </value>
        public double Share { get => this.share; set => this.share = value; }
    }
}