//-----------------------------------------------------------------------
// <copyright file="CollegeSystem.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.StructuralDesignPattern.Adapter
{
    using System;
    using System.Collections.Generic;

    class StudentAdapter : CollegeSystem, ITarget
    {
        public List<string> GetStudentList()
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
    }
}
