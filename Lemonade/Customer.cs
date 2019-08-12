using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class Customer
    {
        //member variables has a
        private int temperaturePreferance;
        private double pricePreferance;
        public bool chooseToBuy;
        Random random;

        //contructor 
        public Customer(Random random, Weather weather, double pricePerCup)
        {
            this.random = new Random();
            this.pricePreferance = random.NextDouble();



            this.temperaturePreferance = random.Next(50, 101);
            MakeDecision(weather, pricePerCup);
        }


        //methods to do
        public void MakeDecision(Weather weather, double pricePerCup)
        {//One part of SOLID user story is the single responsibility.  This method does one thing and one thing only.  It's action is to have the customer make a decision.
            if (temperaturePreferance <= weather.temperature && pricePreferance <= pricePerCup)
            {
                chooseToBuy = true;
                Console.WriteLine("Buy");
            }
        }
    }  
}
