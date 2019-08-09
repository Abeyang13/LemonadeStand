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
        Store store;
        List<Day> days;
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
            profit = playerName.bank - 30;
            Console.WriteLine($"Your total for the week is ${playerName.bank}");
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
            Console.WriteLine("these are the rules\n");
        }
        public void SevenDays()
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
