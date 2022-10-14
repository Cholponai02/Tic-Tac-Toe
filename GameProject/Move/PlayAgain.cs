using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Move
{/// <summary>
/// повтор игры
/// </summary>
    public class PlayAgain : PlayersTurn
    {/// <summary>
    /// сыграть еще раз
    /// </summary>
        public static async Task RepeatGame()
        {

            Console.Write("Would you like to play again? (yes/no)\n> ");
            string answer = Console.ReadLine()??"".ToLower();
            if (answer == "yes")
            {
                field[0] = " ";
                field[1] = " ";
                field[2] = " ";
                field[3] = " ";
                field[4] = " ";
                field[5] = " ";
                field[6] = " ";
                field[7] = " ";
                field[8] = " ";
                PrintField();
                await PlaysAsync();
            }
            else
            {
                Quit.ExitFromGame();
            }
        }
    }
}
