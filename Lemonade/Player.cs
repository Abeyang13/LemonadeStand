using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class Player
    {
        //member variables has a
        public Inventory inventory;
        public double bank;
        public string name;
        public double pricePerCup;


        //contructor 
        public Player()
        {
            inventory = new Inventory(0, 0, 0, 0);
            bank = 30;
        }

        //methods to do
        public void ChooseName()
        {
            Console.Write("Please input your name \n");
            name = Console.ReadLine();
        }
        public void Recipe()
        {
            bool isValid = false;
            while(!isValid)
            { 
                Console.WriteLine("Please select what you want to update for recipe per pitcher made.\n Please input lemons, sugars, icecubes, and cups(for price per up).  Else input exit to exit Recipe");
                string recipe = Console.ReadLine().ToLower();

                switch (recipe)
                {
                    case "lemons":
                        LemonAmount();
                        break;
                    case "sugars":
                        SugarAmount();
                        break;
                    case "icecubes":
                        IceCubeAmount();
                        break;
                    case "cups":
                        CupAmount();
                        break;
                    case "exit":
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine("You have put a invalid input.  Please enter lemons, sugars, icecubes, cups, or exit");
                        Recipe();
                        break;
                } 
            }
        }
        public void LemonAmount()
        {
            Console.WriteLine("How many lemons would you want for recipe?");
            int amountLemonRecipe = int.Parse(Console.ReadLine());
            if(inventory.lemons > amountLemonRecipe)
            {
                inventory.lemons -= amountLemonRecipe;
                inventory.DisplayInventory();
            }
            else
            {
                Console.WriteLine("Not enough in inventory");
                LemonAmount();
            }
        }
        public void SugarAmount()
        {
            Console.WriteLine("How much sugar would you want for recipe?");
            int amountSugarRecipe = int.Parse(Console.ReadLine());
            if (inventory.sugars > amountSugarRecipe)
            {
                inventory.sugars -= amountSugarRecipe;
                inventory.DisplayInventory();
            }
            else
            {
                Console.WriteLine("Not enough in inventory");
                SugarAmount();
            }
        }
        public void IceCubeAmount()
        {
            Console.WriteLine("How much icecubes would you want for recipe?");
            int amountIceRecipe = int.Parse(Console.ReadLine());
            if (inventory.iceCubes > amountIceRecipe)
            {
                inventory.iceCubes -= amountIceRecipe;
                inventory.DisplayInventory();
            }
            else
            {
                Console.WriteLine("Not enough in inventory");
                IceCubeAmount();
            }
        }
        public void CupAmount()
        {//need user validation for this
            Console.WriteLine("How much should a cup of lemonade be?");
            double price = double.Parse(Console.ReadLine());
            pricePerCup = price;
        }
    }
}
