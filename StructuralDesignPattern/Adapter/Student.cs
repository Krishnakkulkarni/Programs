//-----------------------------------------------------------------------
// <copyright file="Student.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.StructuralDesignPattern.Adapter
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The Student class
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The employee source
        /// </summary>
        private readonly ITarget studentSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="employeeSource">The employee source.</param>
        public Student(ITarget employeeSource)
        {
            this.studentSource = employeeSource;
        }

        /// <summary>
        /// Shows the employee list.
        /// </summary>
        public void ShowStudentList()
        {
            List<string> employee = this.studentSource.GetStudentList();

            Console.WriteLine("Student List :");
            foreach (var item in employee)
            {
                Console.Write(item);
            }
        }
    }
}
