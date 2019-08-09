using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class Day
    {
        //member variables has a
        Weather weather;
        List<Customer> customers;
        Random random;
        double moneyAtStartOfDay;


        //contructor 
        public Day(Random random)
        {
            weather = new Weather(random);
            this.random = random;
            weather.RandomTemperature();
            weather.RandomCondition();
        }
        public void RunDay(Player player, Store store)
        {
            //show actual temperature and condiiton 
            weather.ActualTemperature();



            //show inventory 
            moneyAtStartOfDay = player.bank;
            Console.WriteLine(moneyAtStartOfDay);
            player.inventory.DisplayInventory();
            
            //player goes to store 
            store.StoreMenu(player);
            player.Recipe();
            //player goes to stand and start the actual sale of lemonade also have to set recipe
            //recipe cup price added to player.bank everytime a customer buys a cup
            CustomersList();
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[0].chooseToBuy == true)
                {
                    player.bank += player.pricePerCup;
                }
            }
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
