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
        public Inventory(int lemons, int sugars, int iceCubes, int cups)
        {
            this.lemons = lemons;
            this.sugars = sugars;
            this.iceCubes = iceCubes;
            this.cups = cups;
        }

        //methods to do 
        public void InventoryMenu()
        {

            Console.WriteLine("Please select what you want to update.  Type lemons, sugars, cups, iceCubes, or skip to go to next step");
            string item = Console.ReadLine().ToLower();
            switch (item)
            {
                case :


            }


        }

    }
}
