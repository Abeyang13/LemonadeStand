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
        double moneyAtEndOfDay;


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
            //start of Day
            moneyAtStartOfDay = player.bank;
            Console.WriteLine($"{player.name} Your money to start the day is ${moneyAtStartOfDay}\n");
            player.inventory.DisplayInventory();
            //player goes to store after that set recipe
            store.StoreMenu(player);
            player.Recipe();
            Console.WriteLine("Update of Inventory\n");
            //display inventory again to make sure recipe was subtracted from inventory
            player.inventory.DisplayInventory();
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
            moneyAtEndOfDay = player.bank;
            Console.WriteLine($"{player.name} Your money to end the day is ${moneyAtEndOfDay}\n");
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
