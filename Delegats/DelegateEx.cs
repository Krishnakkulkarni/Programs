﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DelegateEx.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Krishna kulkarni"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// demonstration of delegate
    /// </summary>
    public class DelegateEx
    {
        /// <summary>
        /// Delegates the main.
        /// </summary>
        public static void Delegatemain()
        {
            ////creating object
            List<Employee> employeeList = new List<Employee>
            {
                ////storing in the list
                new Employee() { ID = 101, Name = "Mary", Salary = 6000, Experience = 6 },
                new Employee() { ID = 102, Name = "John", Salary = 5000, Experience = 5 },
                new Employee() { ID = 108, Name = "Mike", Salary = 3000, Experience = 3 },
                new Employee() { ID = 104, Name = "Sam", Salary = 4000, Experience = 4 }
            };

            //// calling the method 
            Employee.PromoteEmployee(employeeList, employee => employee.Experience >= 3);
        }
    }
}