using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{/// <summary>
/// класс для инструкции по игре
/// </summary>
    public class InstructionsGame
    {
        /// <summary>
        /// Выводит инструкции
        /// </summary>
        public static void PrintHelp()
        {
            string instruct = @" Tic-tac-toe (American English), noughts and crosses (Commonwealth English), or Xs and Os (Irish English) is a paper-and-pencil game for two players who take turns marking the spaces in a three-by-three grid with X or O. The player who succeeds in placing three of their marks in a horizontal, vertical, or diagonal row is the winner. It is a solved game, with a forced draw assuming best play from both players.
   Games continue until a winner is revealed or the game ends in a draw. The winner is the player who first puts 3 crosses or zeros in a row. (see examples below). Or if this did not happen and there are no more cells left in the “free” state in the game, then the game ends in a draw.
   After the end of the game, display the main menu again, where the player can start the game again.
   When entering a cell index, the user first selects a row and then a column. Indexing starts from one. For example, if the user wants to put a cross in the middle of the field, then he enters “2 2” - the second row and the second column.";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(instruct, Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----Enter the numbers where you want to put \"x\"-----");
            Console.WriteLine("|  1 1  |  2 1  |  3 1  |");
            Console.WriteLine("-------------------------");
            Console.WriteLine("|  1 2  |  2 2  |  3 2  |");
            Console.WriteLine("-------------------------");
            Console.WriteLine("|  1 3  |  2 3  |  3 3  |");
            Console.WriteLine("-------------------------");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
