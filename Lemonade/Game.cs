﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class Game
    {
        //member variables has a
        private Player playerName;
        public int counter;
        Store store;
        List<Day> days;
        Random random;
        



        //contructor 
        public Game()
        {
            store = new Store();
            random = new Random();
            counter = 0;
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
        }
       
        private void DisplayRules()
        {
            Console.WriteLine("these are the rules \n");
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
