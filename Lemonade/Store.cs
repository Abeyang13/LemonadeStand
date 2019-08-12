using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class Store
    {
        //member variables has a
        public double lemon;
        public double sugar;
        public double iceCube;
        public double cup;

        //contructor
        public Store()
        {
            lemon = .20;
            sugar = .25;
            iceCube = .02;
            cup = .05;
        }

        //methods to do
        public void StoreMenu(Player player)
        {
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine("Please select what you would want to purchase.\nPlease input lemon, sugar, icecube, cup, exit (to exit menu), or inventory to go back to look at inventory");
                string storeItem = Console.ReadLine().ToLower();
                switch (storeItem)
                {
                    case "lemon":
                        PurchaseLemon(player);
                        Console.WriteLine($"Your money left after purchase = ${player.bank}");
                        break;
                    case "sugar":
                        PurchaseSugar(player);
                        Console.WriteLine($"Your money left after purchase = ${player.bank}");
                        break;
                    case "icecube":
                        PurchaseIce(player);
                        Console.WriteLine($"Your money left after purchase = ${player.bank}");
                        break;
                    case "cup":
                        PurchaseCup(player);
                        Console.WriteLine($"Your money left after purchase = ${player.bank}");
                        break;
                    case "inventory":
                        User_Interface.DisplayInventory(player.inventory);
                        break;
                    case "exit":
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine("You did not put in a valid input.  Please try again!!");
                        break;
                }
            }
        }
        public void PurchaseLemon(Player player)
        {  
            Console.WriteLine("How many lemons do you want to purchase?");
            int lemonAmount; 
            if (int.TryParse(Console.ReadLine(), out lemonAmount))
            {
                double totalAmount = lemon * lemonAmount;
                if (player.bank > totalAmount)
                {
                    player.bank -= totalAmount;
                    player.inventory.lemons += lemonAmount;
                }
                else
                {
                    Console.WriteLine("Not enough money");
                    PurchaseLemon(player);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number value");
                PurchaseLemon(player);
            }
        }
    public void PurchaseSugar(Player player)
        {
            Console.WriteLine("How much sugar do you want to purchase?");
            int sugarAmount;
            if(int.TryParse(Console.ReadLine(), out sugarAmount))
            {
                double totalAmount = sugar * sugarAmount;
                if (player.bank > totalAmount)
                {
                    player.bank -= totalAmount;
                    player.inventory.sugars += sugarAmount;
                }
                else
                {
                    Console.WriteLine("Not enough money");
                    PurchaseSugar(player);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number value");
                PurchaseSugar(player);
            }
        }
        public void PurchaseIce(Player player)
        {
            Console.WriteLine("How many icecubes do you want to purchase?");
            int iceAmount;
            if(int.TryParse(Console.ReadLine(), out iceAmount))
            {
                double totalAmount = iceCube * iceAmount;
                if (player.bank > totalAmount)

                {
                    player.bank -= totalAmount;
                    player.inventory.iceCubes += iceAmount;
                }
                else
                {
                    Console.WriteLine("Not enough money");
                    PurchaseIce(player);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number value");
                PurchaseIce(player);
            }
        }
        public void PurchaseCup(Player player)
        {
            Console.WriteLine("How many cups do you want to purchase?");
            int cupAmount;
            if(int.TryParse(Console.ReadLine(), out cupAmount))
            {
                double totalAmount = cup * cupAmount;
                if (player.bank > totalAmount)
                {
                    player.bank -= totalAmount;
                    player.inventory.cups += cupAmount;
                }
                else
                {
                    Console.WriteLine("Not enough money");
                    PurchaseCup(player);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number value");
                PurchaseCup(player);
            }
        }
    }
}
