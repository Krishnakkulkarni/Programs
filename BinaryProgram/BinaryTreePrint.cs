//-----------------------------------------------------------------------
// <copyright file="BinaryTreePrint.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DataStructurePrograms.BinaryProgram
{
    using System;

    /// <summary>
    /// Count Binary tree Class
    /// </summary>
    public class BinaryTreePrint
    {
        /// <summary>
        /// Counts the binary tree.
        /// </summary>
        /// <param name="number">The number of elements.</param>
        /// <returns> returns the Count of Binary trees</returns>
        public static double CountBinaryTree(int number)
        {
            try
            {
                int count; ////Calculated value for numerator

                count = FindFactorial(2 * number) / (FindFactorial(number + 1) * FindFactorial(number));

                return count;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// returns the factorial of given Number
        /// </summary>
        /// <param name="number">takes integer</param>
        /// <returns>returns the factorial</returns>
        public static int FindFactorial(int number)
        {
            try
            {
                int factorial = number;

                while (number > 1)
                {
                    factorial = factorial * (number - 1);
                    number--;
                }

                return factorial;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}