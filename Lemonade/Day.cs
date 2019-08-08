using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class Day
    {
        //member variables has a
        public Weather weather;
        public List<Customer> Customers;
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



            //show end the of the day progress for profit or loss



        }
        //methods to do
        private void CustomersList()
        {
            const int numberOfCustomers = 100;
            Customers = new List<Customer>();
            for (int i = 0; i < numberOfCustomers; i++)
            {
                Customer customer = new Customer(40, 61);
                Customers.Add(customer);
            }
        }

    }
}
