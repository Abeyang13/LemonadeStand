using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class Weather
    {
        //member variables has a
        public int temperature;
        public int actualTemperature;
        public string forecast;
        public string actualCondition;
       // public List<string> forecast = new List<string>();
        public string[] conditions = new string[3];
        Random random;



        //contructor 
        public Weather(Random random)
        {
            this.random = random;
        }


        //methods to do 
        public int RandomTemperature()
        {
            return random.Next(50, 100);
        }
        public void RandomCondition()
        {
            conditions[0] = "rain";
            conditions[1] = "cloudy";
            conditions[2] = "sunny";
            Random rng = new Random();
            Console.WriteLine(conditions[rng.Next(0, 2)]);
        }
    }
}