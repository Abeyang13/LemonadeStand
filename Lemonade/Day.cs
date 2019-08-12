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
        private double moneyAtStartOfDay;
        private double moneyAtEndOfDay;


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
            moneyAtStartOfDay = Math.Round(player.bank * 100) / 100;
            Console.WriteLine($"{player.name} Your money to start the day is ${moneyAtStartOfDay}\n");
            User_Interface.DisplayInventory(player.inventory);
            //player goes to store after that set recipe
            store.StoreMenu(player);
            player.Recipe();
            Console.WriteLine("Update of Inventory\n");
            //display inventory again to make sure recipe was subtracted from inventory
            User_Interface.DisplayInventory(player.inventory);
            //recipe cup price added to player.bank everytime a customer buys a cup
            CustomersList(player.pricePerCup);
                for (int i = 0; i < customers.Count; i++)
                {
                    if (customers[i].chooseToBuy == true)
                    {
                        player.bank += player.pricePerCup;
                    }
                }
            //show end of the day progress for profit or loss
            moneyAtEndOfDay = Math.Round(player.bank * 100) / 100;
            Console.WriteLine($"{player.name} Your money to end the day is ${moneyAtEndOfDay}\n");
        }
        private void CustomersList(double pricePerCup)
        {//this has a private method where it is only access it is only accessed in the same class.  Method RunDay has access to information but not the actual game itself.  The game shows customers but doesn't show how we got customer list.
            const int numberOfCustomers = 100;
            customers = new List<Customer>();
            for (int i = 0; i < numberOfCustomers; i++)
            {
                Console.WriteLine($"Customer: {i + 1}");
                Customer customer = new Customer(random, weather, pricePerCup);
                customers.Add(customer);
            }
        }

    }
}
