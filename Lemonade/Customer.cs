﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class Customer
    {
        //member variables has a
        public double wallet;
        public int temperaturePreferance;
        Random random;

        //contructor 
        public Customer(Random random, Weather weather)
        {
            this.random = new Random();
            this.wallet = random.Next(1,10);
            this.temperaturePreferance = random.Next(50, 101);
            MakeDecision(weather);
        }


        //methods to do
        public void MakeDecision(Weather weather)
        {
            if (temperaturePreferance > weather.temperature + 5 && wallet < 8)
            {
                Console.WriteLine("Buy");
            }
        }
    }  
}
