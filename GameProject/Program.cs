using GameProject.Check;
using GameProject.Move;

namespace GameProject
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "GAME - Tic Tac Toe";
            string inputChoice = "0";
            Console.WriteLine(@"Welcome to the tic-tac-toe game. Available commands:
1. ’start’ (or ‘s’) - start the game.
2. ‘help’ (or ‘h’) - show game rules.
3. ‘quit’ (or ‘q’) - quit the game.
");
            for (int cikl = 0; ; cikl++)
            {
                Console.Write("> ");
                inputChoice = Console.ReadLine()??"";
                inputChoice = inputChoice.ToLower().Replace(" ", "").Replace("\t", "");

                if (inputChoice == "s" || inputChoice == "start")
                {
                    Console.Clear();
                    Console.WriteLine("Good luck!");
                    Console.WriteLine("Enter a spot. \"x y\"");
                    PlayersTurn.PrintField();
                    await PlayersTurn.PlaysAsync();
                }
                if (inputChoice == "h" || inputChoice == "help")
                {  
                    InstructionsGame.PrintHelp();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nPlease enter the next command");
                    
                }
                if (inputChoice == "q" || inputChoice == "quit")
                {
                    Quit.ExitFromGame();  
                }
            }
        }
    }
    
}