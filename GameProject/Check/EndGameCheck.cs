using GameProject.Move;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Check
{/// <summary>
/// Проверка на победу или на ничью
/// </summary>
    public class EndGameCheck : Move.PlayersTurn
    {
        public static bool VictoryCheck()
        {
            if (
                (field[0] == field[1] && field[1] == field[2] && field[2] != " ") ||
                (field[3] == field[4] && field[4] == field[5] && field[5] != " ") ||
                (field[6] == field[7] && field[7] == field[8] && field[8] != " ") ||
                (field[0] == field[4] && field[4] == field[8] && field[8] != " ") ||
                (field[2] == field[4] && field[4] == field[6] && field[6] != " ") ||
                (field[0] == field[3] && field[3] == field[6] && field[6] != " ") ||
                (field[1] == field[4] && field[4] == field[7] && field[7] != " ") ||
                (field[2] == field[5] && field[5] == field[8] && field[8] != " ")
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool DeadlockCheck()
        {
            if ((field[0] != " " && VictoryCheck() == false) &&
                (field[1] != " " && VictoryCheck() == false) &&
                (field[2] != " " && VictoryCheck() == false) &&
                (field[3] != " " && VictoryCheck() == false) &&
                (field[4] != " " && VictoryCheck() == false) &&
                (field[5] != " " && VictoryCheck() == false) &&
                (field[6] != " " && VictoryCheck() == false) &&
                (field[7] != " " && VictoryCheck() == false) &&
                (field[8] != " " && VictoryCheck() == false))
            {
                Console.WriteLine(" - - No one has won in this party of the game - -");
                PlayAgain.RepeatGame();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
