using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class Game
    {
        //member variables has a
        private Player playerName;
        double profit;
        private Store store;
        private List<Day> days;
        Random random;
        



        //contructor 
        public Game()
        {
            store = new Store();
            random = new Random();
            playerName = new Player();
        }

        //methods to do 
        public void RunGame()
        {
            DisplayRules();
            playerName.ChooseName();
            Console.WriteLine("Our 7 day forecast is \n");
            SevenDays();
            int numberOfDays = 0;
            while (numberOfDays < 7)
            {
                days[numberOfDays].RunDay(playerName, store);
                numberOfDays++;
            }
            profit = Math.Round(playerName.bank * 100) / 100 - 30;
            Console.WriteLine($"Your total for the week is ${Math.Round(playerName.bank * 100) / 100}");
            if (profit > 0)
            {
                Console.WriteLine($"You Made a Profit of ${profit}");
            }
            else
            {
                Console.WriteLine($"We made a loss and you're eating them cups since we're negative ${profit}");
            }
        }
       
        private void DisplayRules()
        {
            Console.WriteLine("These are the rules:\nPlayer starts with a $30 bank, and they go and buy materials for a lemonade stand.\nThen you set out a recipe for your lemonade stand, and go out and sell the lemonade.\nThe game consist of 7 days and then you add up the total of the week to see if you made a profit or a loss through the week.");
        }
        private void SevenDays()
        {
            const int numberOfDays = 7;
            days = new List<Day>();
            for (int i = 0; i < numberOfDays; i++)
            {
                Console.WriteLine($"Day: {i+1}");
                Day day = new Day(random);
                days.Add(day);
            }
        }
    }
}
