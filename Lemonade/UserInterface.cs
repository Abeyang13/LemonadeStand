using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    static class User_Interface
    {
        //member variables has a


        //contructor 


        //methods to do 
        public static void DisplayInventory(Inventory inventory)
        {
            Console.WriteLine("Your Inventory:");
            Console.WriteLine($"Lemon: {inventory.lemons}");
            Console.WriteLine($"Sugar: {inventory.sugars}");
            Console.WriteLine($"IceCubes: {inventory.iceCubes}");
            Console.WriteLine($"Cups: {inventory.cups}\n");
        }
    }
}
