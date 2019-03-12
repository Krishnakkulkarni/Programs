//-----------------------------------------------------------------------
// <copyright file="BinaryTreeInput.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DataStructurePrograms.BinaryProgram
{
    using System;

    /// <summary>
    /// Input for Binary
    /// </summary>
    public class BinaryTreeInput
    {
        /// <summary>
        /// Binaries the tree.
        /// </summary>
        public static void BinaryTree()
        {
            try
            {
                int numberOfElements = 0;
                bool loop = true;
                while (loop)
                {
                    Console.WriteLine("Enter the Number Of Elements");
                    string stringElements = Console.ReadLine();

                    if (UtilityClass.IsNumber(stringElements) == false)
                    {
                        Console.WriteLine("Invalid Input");
                        continue;
                    }

                    numberOfElements = Convert.ToInt32(stringElements);

                    if (numberOfElements < 0)
                    {
                        Console.WriteLine("the Number of elements should be greater than 0");
                        continue;
                    }

                    loop = false;
                }

                double numberOfBinaryTrees = BinaryTreePrint.CountBinaryTree(numberOfElements);
                Console.WriteLine("Number Of Binary trees possible = " + numberOfBinaryTrees);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}