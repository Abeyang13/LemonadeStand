using System;

namespace Lemonade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Day day = new Day(new Random());
            //Console.WriteLine(day);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Game game = new Game();
            game.RunGame();
            //Store store = new Store();
            //store.StoreMenu();
            //Console.ReadLine();


        }
    }
}
