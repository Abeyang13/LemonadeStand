using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class Player
    {
        //member variables has a
        public Inventory inventory;
        public double stand;
        public string name;
        public int recipe;


        //contructor 
        public Player()
        {
        }

        //methods to do
        public void ChooseName()
        {
            Console.Write("Please input your name");
            name = Console.ReadLine();
        }
        public void StandRecipe()
        {

        }

    }
}
