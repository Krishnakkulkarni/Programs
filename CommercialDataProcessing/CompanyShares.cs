//-----------------------------------------------------------------------
// <copyright file="CompanyShares.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    using System;

    /// <summary>
    /// Input for companyshares
    /// </summary>
    public class CompanyShares
    {
        /// <summary>
        /// 
        /// </summary>
        private long number_shares;

        /// <summary>
        /// 
        /// </summary>
        private double price_shares;

        /// <summary>
        /// 
        /// </summary>
        private string symbol;

        /// <summary>
        /// 
        /// </summary>
        private string date_time;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number_shares"></param>
        /// <param name="price_shares"></param>
        /// <param name="symbol"></param>
        /// <param name="date_time"></param>
        public CompanyShares(long number_shares, double price_shares, string symbol, string date_time)
        {
            this.number_shares = number_shares;
            this.price_shares = price_shares;
            this.symbol = symbol;
            this.date_time = date_time;
        }

        /// <summary>
        /// 
        /// </summary>
        public long Number_shares
        {
            get { return this.number_shares;  }
            set { this.number_shares = value;  }
        }

        /// <summary>
        /// 
        /// </summary>
        public double Price_shares
        {
            get { return this.price_shares; }
            set { this.price_shares = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Symbol
        {
            get { return this.symbol; }
            set { this.symbol = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Date_time
        {
            get { return this.date_time; }
            set { this.date_time = value; }
        }
    }
}
