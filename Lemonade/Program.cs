using System;

namespace Lemonade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Game game = new Game();
            game.RunGame();
        }
    }
}
