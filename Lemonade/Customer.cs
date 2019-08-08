using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class Customer
    {
        //member variables has a
        Random random;
        public int chanceToBuy;


        //contructor 
        public Customer(int min, int max)
        {
            Random chanceToBuy = new Random();
            this.chanceToBuy = chanceToBuy.Next(min, max);
        }


        //methods to do
        public void MakeDecision(Weather weather, Player player)
        {
            //if (weather.temperature <= 70 && player.recipe)
        }
    }  
}
