using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class Weather
    {
        //member variables has a
        public int temperature;
        public string[]conditions = new string[3];
        Random random;



        //contructor 
        public Weather(Random random)
        {
            this.random = random;
            
        }


        //methods to do 
        public void RandomTemperature()
        {
            Random random = new Random();
            int generateTemp = random.Next(50, 100);
            temperature = generateTemp;
            Console.WriteLine(" Today's temperature is " + temperature);
        }
        public void RandomCondition()
        {
            conditions[0] = "rainy";
            conditions[1] = "cloudy";
            conditions[2] = "sunny";
            Random rng = new Random();
            Console.WriteLine(" Today is also " + conditions[rng.Next(0,3)] + "\n");
        }
    }
}