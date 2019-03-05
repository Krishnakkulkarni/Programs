//-----------------------------------------------------------------------
// <copyright file="TIC_TAC_TOE.cs" company="Bridgelabz">
//     Company @ 2019 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /// <summary>
    /// class to play TIC_TAC_TOE
    /// </summary>
    public class Tic_Tac_Toe
    {
        /// <summary>
        /// Method to take input and call from Main method
        /// </summary>
        public static void Tic_tac_toe()
        {
            try
            {
                char[] array = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                int player = 1; // By default player 1 is set  
                int choice = 0; // This holds the choice at which position user want to mark   
                            // The flag veriable checks who has won
                            // if it's value is 1 then some one has won the match if -1 then Match has Draw if 0 then match is still running.  
                int flag = 0;
                UtilityClass.Game(array, player, choice, flag);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
