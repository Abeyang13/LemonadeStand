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
            this.random = new Random();
            weather.RandomTemperature();
            weather.RandomCondition();



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
