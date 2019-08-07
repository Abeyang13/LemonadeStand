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
        public List<Day> Days;
        private Store store;
        private Random random;
        private int forecast;
        



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
            SevenDays();

            

        }
        private void DisplayRules()
        {
            Console.WriteLine("these are the rules");
        }
        public void SevenDays()
        {
            const int numberOfDays = 7;
            Days = new List<Day>();   
            for (int i = 0; i < numberOfDays; i++)
            {
                Day day = new Day(random);
                Days.Add(day);      
            }
        }

    }
}
