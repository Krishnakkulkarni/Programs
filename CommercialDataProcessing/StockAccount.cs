
namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;

    public class StockAccount : IStockAccount
    {
        public void Buy(long number_shares, double price_shares, string symbol)
        {
            List<CompanyShares> companyShares = ReadWritefile.ReadFromFile();

            foreach(CompanyShares shares in companyShares)
            {
                if (shares.Symbol.Equals(symbol))
                    Console.WriteLine("");
                return;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public interface IStockAccount
    {
        void Buy(long number_shares, double price_shares, string symbol);
        void printReport();
    }
}
