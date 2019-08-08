using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class Weather
    {
        //member variables has a
        public int temperature;
        public string condition;
        public string[] conditions = new string[3];
        Random random;



        //contructor 
        public Weather(Random random)
        {
            this.random = random;
        }


        //methods to do 
        public void RandomTemperature()
        {
            temperature = random.Next(50,100);
            Console.WriteLine(" Today's temperature is " + temperature);
        }
        public void RandomCondition()
        {
            
            conditions[0] = "rainy";
            conditions[1] = "cloudy";
            conditions[2] = "sunny";
            Random rng = new Random();
            string ex = conditions[rng.Next(0, 3)];
            condition = ex;
            Console.WriteLine(" Today is also " + condition + "\n");
        }

        public void ActualTemperature()
        {
            Console.WriteLine(" Today's forecast is " + temperature + " degrees and " + condition);
            temperature = random.Next(temperature - 5, temperature + 5);
            Console.WriteLine(" Actual temperature is " + temperature + " degrees and " + condition);
        }
    }
}