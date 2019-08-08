using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class Game
    {
        //member variables has a
        private Player playerName;
        public int counter;
        List<Day> days;
        Store store;
        Random random;
        



        //contructor 
        public Game()
        {
            random = new Random();
            counter = 0;
            
        }

        //methods to do 
        public void RunGame()
        {
            DisplayRules();
            Console.WriteLine("Our 7 day forecast is \n");
            SevenDays();

            int numberOfDays = 0;

            while (numberOfDays < 7)
            {

                days[numberOfDays].RunDay(playerName);
                numberOfDays++;

            }
           

            

            

        }
        private void DisplayRules()
        {
            Console.WriteLine("these are the rules");
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
