//-----------------------------------------------------------------------
// <copyright file="CollegeSystem.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.StructuralDesignPattern.Adapter
{
    using System;

    /// <summary>
    /// Adapter Class 
    /// </summary>
    public class CollegeSystem
    {
        /// <summary>
        /// Method to get array of strings
        /// </summary>
        /// <returns>returns string</returns>
        public string[][] GetStudents()
        {
            try
            {
                string[][] student = new string[4][];
                student[0] = new string[] { "100", "Deepak", "67%" };
                student[1] = new string[] { "101", "Rohit", "78%" };
                student[2] = new string[] { "102", "Gautam", "85%" };
                student[3] = new string[] { "103", "Dev", "55%" };
                return student;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
