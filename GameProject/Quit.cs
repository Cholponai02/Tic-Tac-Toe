using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{/// <summary>
/// класс для выхода из игры
/// </summary>
    public class Quit
    {/// <summary>
    /// выходит из игры
    /// </summary>
        public static void ExitFromGame()
        {
            Console.WriteLine("Bye!");
            Environment.Exit(0);
        }
    }
}
