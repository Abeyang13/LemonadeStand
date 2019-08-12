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
        public int amountLemonRecipe;
        public int amountSugarRecipe;
        public int amountIceRecipe;


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
                Console.WriteLine("Please select what you want to update for recipe per pitcher made.\nPlease input lemons, sugars, icecubes, and cups(for price per up).  Else input exit to exit Recipe Menu");
                string recipe = Console.ReadLine().ToLower();

                switch (recipe)
                {
                    case "lemons":
                        LemonAmount();
                        Console.WriteLine("Recipe:");
                        RecipeDisplay();
                        break;
                    case "sugars":
                        SugarAmount();
                        Console.WriteLine("Recipe:");
                        RecipeDisplay();
                        break;
                    case "icecubes":
                        IceCubeAmount();
                        Console.WriteLine("Recipe:");
                        RecipeDisplay();
                        break;
                    case "cups":
                        CupAmount();
                        Console.WriteLine("Recipe:");
                        RecipeDisplay();
                        break;
                    case "exit":
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine("You have put a invalid input.  Please enter lemons, sugars, icecubes, cups, or exit");
                        break;
                }
            }
        }
        public void LemonAmount()
        {
            Console.WriteLine("How many lemons would you want for recipe?");
            if (int.TryParse(Console.ReadLine(), out amountLemonRecipe))
            {
                if (inventory.lemons >= amountLemonRecipe)
                {
                    inventory.lemons -= amountLemonRecipe;
                }
                else
                {
                    Console.WriteLine("Not enough in inventory");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number value");
                LemonAmount();
            }
        }
        public void SugarAmount()
        {
            Console.WriteLine("How much sugar would you want for recipe?");
            if (int.TryParse(Console.ReadLine(), out amountSugarRecipe))
            {
                if (inventory.sugars >= amountSugarRecipe)
                {
                    inventory.sugars -= amountSugarRecipe;
                }
                else
                {
                    Console.WriteLine("Not enough in inventory");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number value");
                SugarAmount();
            }
        }
        public void IceCubeAmount()
        {
            Console.WriteLine("How much icecubes would you want for recipe?");
            if (int.TryParse(Console.ReadLine(), out amountIceRecipe))
            {
                if (inventory.iceCubes >= amountIceRecipe)
                {
                    inventory.iceCubes -= amountIceRecipe;
                }
                else
                {
                    Console.WriteLine("Not enough in inventory");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number value");
                IceCubeAmount();
            }
        }
        public void CupAmount()
        {//need user validation for this
            Console.WriteLine("How much should a cup of lemonade be?");
            double price;
            if(double.TryParse(Console.ReadLine(), out price))
            {
                pricePerCup = price;
            }
            else
            {
                Console.WriteLine("Please enter a valid number value");
                CupAmount();
            }
           
        }
        public void RecipeDisplay()
        {
            Console.WriteLine($"Lemon = {amountLemonRecipe}");
            Console.WriteLine($"Sugar = {amountSugarRecipe}");
            Console.WriteLine($"IceCube = {amountIceRecipe}");
            Console.WriteLine($"Cup price = {pricePerCup}");
        }
    }
}
