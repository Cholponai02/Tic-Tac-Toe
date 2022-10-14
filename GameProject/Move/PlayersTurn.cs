using GameProject.Check;
using GameProject.ErrorMove;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Move
{/// <summary>
/// ход игроков
/// </summary>
    public class PlayersTurn
    {
        public static string[] field = { " ", " ", " ",
                                         " ", " ", " ",
                                         " ", " ", " " };
        /// <summary>
        /// показывает игровое поле
        /// </summary>
        public static void PrintField()
        {
            Console.WriteLine("Current field state: ");
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", field[0], field[1], field[2]);
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", field[3], field[4], field[5]);
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", field[6], field[7], field[8]);
            Console.WriteLine("-------------");

        }
        /// <summary>
        /// ввод игрока
        /// </summary>
        public static async Task PlaysAsync(CancellationToken token = default)
        {
            char[] xSpaceY = {' '};
            Console.Write("Now it is your turn. Please enter index of the cell you’d like to put the cross in::\n> ");
            string[] positions = Console.ReadLine().Split(xSpaceY);
            int x = Int32.Parse(positions[0]);
            int y = Int32.Parse(positions[1]);

            if (!(WrongMove.PositionInput(x) && WrongMove.PositionInput(y)))
            {
                await PlaysAsync();
            }

            int index = GetIndex(x, y);
            if (WrongMove.PositionOpen(index))
            {
                field[index] = "X";
                PrintField(); 
            }
            else
            {
                await PlaysAsync();
            }

            if (EndGameCheck.VictoryCheck())
            {
                PrintField();
                Console.WriteLine("Great! You’ve nailed it.");
                await PlayAgain.RepeatGame();
            }
            else
            {
                EndGameCheck.DeadlockCheck();
            }
            await ComputerMoveAsync();
            PrintField(); 
            await PlaysAsync();
        }
        /// <summary>
        /// возвращает введенные значения
        /// </summary>
        static int GetIndex(int x, int y)
        {
            return (x - 1) + (y - 1) * 3;
        }
        /// <summary>
        /// ход компьютера
        /// </summary>
        static async Task ComputerMoveAsync(CancellationToken token = default)
        {
            int[] openSpots = { -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            int count = 0;
            int winningPosition = 0;
            for (int i = 0; i <= 8; i++)
            {
                if (field[i] == " ")
                {
                    openSpots[count] = i;
                    count = count + 1;
                }

            }
            winningPosition = CheckMove.VictoryMoveCheck("O", openSpots); //победный ход для компьютера
            if (winningPosition != -1)
            {
                field[winningPosition] = "O";
            }
            else
            {
                winningPosition = CheckMove.VictoryMoveCheck("X", openSpots);//победный ход для пользователя

                if (winningPosition != -1)
                {
                    field[winningPosition] = "O";
                }
                else
                {
                    Random rnd = new Random(); //победной позиции не найдено - ставит рандомно
                    int randomInteger = rnd.Next(0, count);
                    field[openSpots[randomInteger]] = "O";

                }
            }
            Console.WriteLine("Now it is the computer's turn…");
            Random rndTime = new Random();
            int time = rndTime.Next(500, 2000);
            await Task.Delay(time);
            Console.WriteLine("The computer decided to go");
            if (EndGameCheck.VictoryCheck() == true)
            {
                PrintField();
                Console.WriteLine("You lose!");
                await PlayAgain.RepeatGame();
                await PlaysAsync();
            }
        }
    }
}
