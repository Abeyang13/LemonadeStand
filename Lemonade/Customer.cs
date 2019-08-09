using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class Customer
    {
        //member variables has a
        public int temperaturePreferance;
        public int pricePreferance;
        public bool chooseToBuy;
        Random random;

        //contructor 
        public Customer(Random random, Weather weather)
        {
            this.random = new Random();
            this.pricePreferance = random.Next(5, 41) / 100;
            this.temperaturePreferance = random.Next(50, 101);
            MakeDecision(weather);
        }


        //methods to do
        public void MakeDecision(Weather weather)
        {
           
            if (temperaturePreferance <= weather.temperature && pricePreferance < 32)
            {
                chooseToBuy = true;
                Console.WriteLine("Buy");
            }
        }
    }  
}
