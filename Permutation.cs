namespace FunctionalPrograms
{
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>
class Permutation
    {
        /// <summary>
        /// 
        /// </summary>
        public static void PermutationNumber()
        {
            Console.WriteLine("enter the String");
            string str = Console.ReadLine();
            int n = str.Length;
            UtilityClass.Permute(str, 0, n - 1);
        }
    }
}

