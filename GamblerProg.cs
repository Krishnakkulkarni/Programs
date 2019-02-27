namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// To find gambler
    /// </summary>
    public class GamblerProg
    {
        public static void Gamblerno()
        {
            ///Testing
            Console.WriteLine("enter the $stake number ");
            int stake = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the goal number ");
            int goal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the no number ");
            int n = Convert.ToInt32(Console.ReadLine());
            UtilityClass.gamblernum(stake, goal, n);
        }
    }
}
