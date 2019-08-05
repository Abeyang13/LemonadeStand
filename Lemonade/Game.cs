using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade
{
    class Game
    {
        //member variables has a
        public string player;
        List<string> customers = new List<string>();
        public string rules;
        public int counter;



        //contructor 


        //methods to do 
        public void RunGame()
        {
            DisplayRules();



        }
        private string DisplayRules()
        {
            Console.WriteLine("these are the rules");
            rules = Console.ReadLine();
            return rules;
        }
    }
}
