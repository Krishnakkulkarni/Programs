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
    public class TIC_TAC_TOE
    {
        public static void Tic_tac_toe()
        {
            char[] array = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int player = 1; // By default player 1 is set  
            int choice = 0; // This holds the choice at which position user want to mark   
                        // The flag veriable checks who has won
                        // if it's value is 1 then some one has won the match if -1 then Match has Draw if 0 then match is still running.  
            int flag = 0;
            UtilityClass.Game(array,player,choice,flag);
        }
    }
}
