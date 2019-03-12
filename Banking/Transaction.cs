//-----------------------------------------------------------------------
// <copyright file="Transaction.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace OrderedList.Banking
{
    using System;
    using DataStructurePrograms;

    /// <summary>
    /// Can deposit and withdraw
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Deposits the details.
        /// </summary>
        /// <param name="person">The person.</param>
        public static void DepositeDetails(Person person)
        {
            try
            {
                //// loops untill deposite is complete
                bool loopDeposite = true;

                while (loopDeposite)
                {
                    Console.WriteLine("Enter the Money you want to Deposite,You have currently " + person.Balance + " in your account");
                    string amountToDeposite = Console.ReadLine();

                    if (UtilityClass.IsNumber(amountToDeposite) == false)
                    {
                        Console.WriteLine("Invalid Input");
                        continue;
                    }

                    if (person.Deposite(Convert.ToInt32(amountToDeposite)) == false)
                    {
                        continue;
                    }

                    loopDeposite = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Withdraws the amount .
        /// </summary>
        /// <param name="person">The person.</param>
        public static void WithdrawlDetails(Person person)
        {
            try
            {
                //// loops untill valid withdrawl is complete
                bool loopWithdraw = true;
                while (loopWithdraw)
                {
                    Console.WriteLine("Enter the Money you want to Withdraw,You have currently " + person.Balance + " in your account");
                    string amountToWithdraw = Console.ReadLine();

                    if (UtilityClass.IsNumber(amountToWithdraw) == false)
                    {
                        Console.WriteLine("Invalid Input");
                        continue;
                    }

                    if (person.Withdraw(Convert.ToInt32(amountToWithdraw)) == false)
                    {
                        continue;
                    }

                    loopWithdraw = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}