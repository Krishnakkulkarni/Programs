//-----------------------------------------------------------------------
// <copyright file="Address.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms.AddressBook
{
    using System;

    /// <summary>
    /// A class for address book information
    /// </summary>
    public class Address
    {
        /// <summary>
        /// A method Book details
        /// </summary>
        public void BookDetails()
        {
            UtilityAddress utilityAddress = new UtilityAddress();
            //// choose an option to perform operation in address book
            Console.WriteLine("1. Add person, 2. Delete, 3. Update, 4. Sort by last name, 5. sort by zip, 6. print address book");
            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    utilityAddress.AddPerson();
                    break;

                case "2":
                    utilityAddress.DeleteData();
                    break;
                case "3":
                    utilityAddress.Update();
                    break;
                case "4":
                    utilityAddress.SortByLastName();
                    break;
                case "5":
                    utilityAddress.SortByZip();
                    break;
                case "6":
                    utilityAddress.PrintAddressBook();
                    break;
            }
        }
    }
}