﻿//-----------------------------------------------------------------------
// <copyright file="MainMediator.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.Mediator
{
    using System;

    /// <summary>
    /// Class for main mediator
    /// </summary>
    public class MainMediator
    {
        /// <summary>
        /// Mediators this instance.
        /// </summary>
        public static void Mediator()
        {
            try
            {
                //// Creating mediator object
                ConcretMediator mediator = new ConcretMediator();

                //// Creating classes and passing the mediator reference
                ConcretColleague1 colleague1 = new ConcretColleague1(mediator);
                ConcretColleague2 colleague2 = new ConcretColleague2(mediator);

                mediator.Colleague1 = colleague1;
                mediator.Colleague2 = colleague2;

                colleague1.Send("How are you?");
                colleague2.Send("Fine, thanks");

                //// Waits for the user
                Console.ReadKey();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}