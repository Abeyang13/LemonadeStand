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
            iceCube = .2;

        }





        //methods to do
        public void StoreMenu()
        {
            Console.WriteLine($"Lemons are {lemon}"); 


        }
    }
}
