//-----------------------------------------------------------------------
// <copyright file="CashCounter.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace OrderedList.Banking
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /// <summary>
    /// Simulates Banking cash Counter
    /// </summary>
    public class CashCounter
    {
        /// <summary>
        /// Counters this instance.
        /// </summary>
        public static void Counter()
        {
            try
            {
                string personName = string.Empty;
                int option = 0;
                Person[] personArray;
                int personNumber = 1; //// specifies the current number of person at the queue
                int numberOfPeople = 0; //// number of people in Queue
                int balance = 0;

                Queue queue = new Queue(); //// creating queue object

                //// keeps looping untill valid input for no. of people is given.
                bool loopNumberOfPeople = true;
                while (loopNumberOfPeople)
                {
                    Console.WriteLine("Enter the Number of people in Queue");
                    string stringNumberOfPeople = Console.ReadLine();
                    if (Utility.IsNumber(stringNumberOfPeople) == false)
                    {
                        Console.WriteLine("Invalid Input ");
                        continue;
                    }

                    numberOfPeople = Convert.ToInt32(stringNumberOfPeople);
                    if (numberOfPeople <= 0)
                    {
                        Console.WriteLine("There must be atleast one person in Queue");
                        continue;
                    }

                    loopNumberOfPeople = false;
                }

                personArray = new Person[numberOfPeople];
                for (int i = 0; i < numberOfPeople; i++)
                {
                    ////keeps looping untill valid input for persons name is given
                    bool loopPersonName = true;
                    while (loopPersonName)
                    {
                        Console.WriteLine("Enter the Name for the " + personNumber + " person");
                        personName = Console.ReadLine();

                        if (Utility.CheckString(personName))
                        {
                            Console.WriteLine("Please Provide a name");
                            continue;
                        }

                        if (Utility.ContainsCharacter(personName))
                        {
                            Console.WriteLine("No Characters allowed");
                            continue;
                        }

                        //// checks if person name contains any Number in it.
                        if (Utility.IsNumber(personName))
                        {
                            Console.WriteLine("Please provide a proper name");
                            continue;
                        }

                        loopPersonName = false;
                    }

                    //// keeps looping until valid positive balance input is given.
                    bool loopForBalance = true;
                    while (loopForBalance)
                    {
                        Console.WriteLine("Enter the Balance for person " + personName);
                        string stringBalance = Console.ReadLine();

                        if (Utility.IsNumber(stringBalance) == false)
                        {
                            Console.WriteLine("invalid input");
                            continue;
                        }

                        balance = Convert.ToInt32(stringBalance);
                        loopForBalance = false;
                    }

                    personNumber++;

                    personArray[i] = new Person(personName, balance);
                }

                //// loops as many as the number of people
                for (int i = 0; i < numberOfPeople; i++)
                {
                    queue.Enqueue(personArray[i]); //// adding to the queue one by one
                }

                Console.WriteLine("All " + numberOfPeople + " people are Enqueued");

                int person = 0; //// this for accessing as index for personArray.

                bool loop = true;
                while (loop)
                {
                    Console.WriteLine("Person " + personArray[person].Name + " is at Counter");
                    Console.WriteLine("What do you want to do");
                    Console.WriteLine("1) deposite");
                    Console.WriteLine("2) withdraw");
                    Console.WriteLine("3) Check the Size of queue");
                    string stringOption = Console.ReadLine();

                    if (Utility.IsNumber(stringOption) == false)
                    {
                        Console.WriteLine("Please provide Correct input");
                        continue;
                    }

                    option = Convert.ToInt32(stringOption);
                    switch (option)
                    {
                        case 1:
                            {
                                TransactionInput.DepositeDetails(personArray[person]);
                                queue.Dequeue();
                                person = person + 1;

                                if (queue.CheckSize() == 0)
                                {
                                    loop = false;
                                }

                                break;
                            }

                        case 2:
                            {
                                TransactionInput.WithdrawlDetails(personArray[person]);
                                queue.Dequeue();
                                person = person + 1;
                                if (queue.CheckSize() == 0)
                                {
                                    loop = false;
                                }

                                break;
                            }

                        case 3:
                            {
                                int size = queue.CheckSize();
                                Console.WriteLine("There are " + size + " in queue");
                                break;
                            }

                        default:
                            {
                                Console.WriteLine("Invalid Input");
                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}