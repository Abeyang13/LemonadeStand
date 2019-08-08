using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class Inventory
    {
        //member variables has a
        public int lemons;
        public int sugars;
        public int iceCubes;
        public int cups;

        //contructor 
        public Inventory()
        {

        }

        //methods to do 
        public void InventoryMenu()
        {
            Console.WriteLine("Please select what you want to update.  Type lemon, sugar, cup, iceCube, or Type skip to go to next step");

        }

    }
}
