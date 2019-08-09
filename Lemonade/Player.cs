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
        public void StandRecipe()
        {
            Console.WriteLine("Please select what you want to update for recipe.  Enter amount of lemons, sugar, icecubes you want per cup");
            string recipe = Console.ReadLine().ToLower();
            switch (recipe)
            {
                case 1:  "lemons";
                    break;

            }
        }

    }
}
