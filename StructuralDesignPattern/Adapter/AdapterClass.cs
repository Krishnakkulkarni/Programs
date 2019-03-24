//-----------------------------------------------------------------------
// <copyright file="AdapterClass.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name="Krishna Kulkarni"/>
//-----------------------------------------------------------------------

namespace DesignPattern.StructuralDesignPattern.Adapter
{
    using System;

    /// <summary>
    /// Entry point
    /// </summary>
    public class AdapterClass
    {
        /// <summary>
        /// Adapters this instance.
        /// </summary>
        public static void Adapter()
        {
            ITarget Itarget = new StudentAdapter();
            Student client = new Student(Itarget);
            client.ShowStudentList();

            Console.ReadKey();
        }
    }
}
