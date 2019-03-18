//-----------------------------------------------------------------------
// <copyright file="CompanyShares.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    using System;

    /// <summary>
    /// Input for company shares
    /// </summary>
    public class CompanyShares
    {
        /// <summary>
        /// Instance of number of shares
        /// </summary>
        private long numberofshares;

        /// <summary>
        /// Instance of price_shares
        /// </summary>
        private double priceofshares;

        /// <summary>
        /// Instance of symbol
        /// </summary>
        private string symbol;

        /// <summary>
        /// Instance of date_time
        /// </summary>
        private string dateAndtime;

        /// <summary>
        /// Instance of Company Shares
        /// </summary>
        /// <param name="numberofshares">numberofshares as a parameter</param>
        /// <param name="priceofshares">priceofshares as a parameter</param>
        /// <param name="symbol">symbol as a parameter</param>
        /// <param name="dateAndtime">date_time as a parameter</param>
        public CompanyShares(long numberofshares, double priceofshares, string symbol, string dateAndtime)
        {
            this.Numberofshares = numberofshares;
            this.Priceofshares = priceofshares;
            this.Symbol = symbol;
            this.dateAndtime = dateAndtime;
        }

        /// <summary>
        /// Instance of Number of shares
        /// </summary>
        public long Numberofshares { get => this.numberofshares; set => this.numberofshares = value; }

        /// <summary>
        /// Instance of Price of shares
        /// </summary>
        public double Priceofshares { get => this.priceofshares; set => this.priceofshares = value; }

        /// <summary>
        /// Instance of symbol
        /// </summary>
        public string Symbol { get => this.symbol; set => this.symbol = value; }

        /// <summary>
        /// Instance of Date time
        /// </summary>
        public string DateTime { get => this.dateAndtime; set => this.dateAndtime = value; }
    }
}
