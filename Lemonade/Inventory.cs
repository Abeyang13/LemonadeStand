﻿using System;
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
        public void DisplayInventory()
        {
            Console.WriteLine("Your Inventory:");
            Console.WriteLine($"Lemon: {lemons}");
            Console.WriteLine($"Sugar: {sugars}");
            Console.WriteLine($"IceCubes: {iceCubes}");
            Console.WriteLine($"Cups: {cups}\n");
        }

    }
}
