//-----------------------------------------------------------------------
// <copyright file="IStockAccount.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    /// <summary>
    /// Interface of Stock Account
    /// </summary>
    public interface IStockAccount
    {
        /// <summary>
        /// Method to buy
        /// </summary>
        /// <param name="numberofshares">number of Shares</param>
        /// <param name="priceofshares">price of shares</param>
        /// <param name="symbol">symbol</param>
        void Buy(long numberofshares, double priceofshares, string symbol);

        /// <summary>
        /// Method to print
        /// </summary>
        void PrintReport();
    }
}