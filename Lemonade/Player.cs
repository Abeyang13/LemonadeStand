using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class Player
    {
        //member variables has a
        Inventory inventory;
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

        }

    }
}
