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
            Console.WriteLine("Please select what you would want to purchase. Please input lemon, sugar, icecube, cup, or back to go back to inventory menu");
            string storeItem = Console.ReadLine().ToLower();
            switch (storeItem)
            {
                case "lemon":
                    PurchaseLemon(player);
                    break;
                case "sugar":
                    PurchaseSugar(player);
                    break;
                case "icecube":
                    PurchaseIce(player);
                    break;
                case "cup":
                    PurchaseCup(player);
                    break;
                case "back":
                    player.inventory.InventoryMenu();
                    break;
                default:
                    Console.WriteLine("You did not put in a valid input.  Please try again!!");
                    StoreMenu(player);
                    break;
            } 

        }
        public void PurchaseLemon(Player player)
        {
            Console.WriteLine("How many lemons do you want to purchase?");
            Console.ReadLine();
        }
        public void PurchaseSugar(Player player)
        {
            Console.WriteLine("How much sugar do you want to purchase?");
            Console.ReadLine();
        }
        public void PurchaseIce(Player player)
        {
            Console.WriteLine("How many icecubes do you want to purchase?");
            Console.ReadLine();
        }
        public void PurchaseCup(Player player)
        {
            Console.WriteLine("How many cups do you want to purchase?");
            Console.ReadLine();
        }
    }
}
