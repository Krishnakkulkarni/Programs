//-----------------------------------------------------------------------
// <copyright file="StudentAdapter.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.StructuralDesignPattern.Adapter
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Adapter class Implementation
    /// </summary>
    public class StudentAdapter : CollegeSystem, ITarget
    {
        /// <summary>
        /// Method of list of strings
        /// </summary>
        /// <returns>returns list of string</returns>
        public List<string> GetStudentList()
        {
            try
            {
                List<string> studentList = new List<string>();
                string[][] student = GetStudents();
                foreach (string[] stud in student)
                {
                    studentList.Add(stud[0]);
                    studentList.Add(",");
                    studentList.Add(stud[1]);
                    studentList.Add(",");
                    studentList.Add(stud[2]);
                    studentList.Add("\n");
                }

            return studentList;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
