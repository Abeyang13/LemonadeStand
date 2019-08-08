using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class Day
    {
        //member variables has a
        public Weather weather;
        List<Customer> customers;
        Random random;
        


        //contructor 
        public Day(Random random)
        { 
            weather = new Weather(random);
            this.random = random;
            weather.RandomTemperature();
            weather.RandomCondition();
        }
        public void RunDay(Player player)
        {
            //show actual temperature and condiiton 
            weather.ActualTemperature();



            //show inventory 



            //player goes to store 



            //player goes to stand and start the actual sale of lemonade
            CustomersList();


            //show end the of the day progress for profit or loss



        }
        public void CustomersList()
        {
            const int numberOfCustomers = 100;
            customers = new List<Customer>();
            for (int i = 0; i < numberOfCustomers; i++)
            {
                Console.WriteLine($"Customer: {i + 1}");
                Customer customer = new Customer(random, weather);
                customers.Add(customer);
            }
        }

    }
}
