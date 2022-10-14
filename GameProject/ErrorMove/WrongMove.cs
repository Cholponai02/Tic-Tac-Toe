using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.ErrorMove
{/// <summary>
/// ошибка при ходе
/// </summary>
    public class WrongMove : Move.PlayersTurn
    {/// <summary>
    /// неправильный ход
    /// </summary>
        public static bool PositionInput(int num)
        {
            if (num > 0 && num <= 3)
            {
                return true;
            }
            else
            {
                Console.WriteLine("You went wrong, try again...");
                return false;
            }
        }
        /// <summary>
        /// место для хода уже занят
        /// </summary>
        public static bool PositionOpen(int i)
        {
            if (field[i] == "X" || field[i] == "O")
            {
                Console.WriteLine("This place is already taken. Try again");
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
