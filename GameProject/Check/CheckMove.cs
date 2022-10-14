using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Check
{/// <summary>
/// Для проверки хода
/// </summary>
    public class CheckMove : Move.PlayersTurn
    {/// <summary>
    /// проверка победного хода
    /// </summary>
        public static int VictoryMoveCheck(string playerTurn, int[] emptyPlace)
        {
            int maxAccessible = 0;
            for (int i = 0; i <= emptyPlace.Length - 1; i++)
            {
                if (emptyPlace[i] != -1) { maxAccessible = i; };
            }

            for (int i = 0; i <= maxAccessible; i++)
            {
                if (field[emptyPlace[i]] == " ")
                {
                    field[emptyPlace[i]] = playerTurn;
                    if (EndGameCheck.VictoryCheck() == true)
                    {
                        return (emptyPlace[i]);
                    }
                }
                field[emptyPlace[i]] = " ";
            }
            return -1;
        }
    }
}
