//-----------------------------------------------------------------------
// <copyright file="CollegeSystem.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.StructuralDesignPattern.Adapter
{
    using System;

    public class CollegeSystem
    {
        public string[][] GetStudents()
        {
            string[][] student = new string[4][];

            student[0] = new string[] { "100", "Deepak", "67%" };
            student[1] = new string[] { "101", "Rohit", "78%" };
            student[2] = new string[] { "102", "Gautam", "85%" };
            student[3] = new string[] { "103", "Dev", "55%" };

            return student;
        }
    }
}
