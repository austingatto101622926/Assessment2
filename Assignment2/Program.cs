using System;
using System.Collections.Generic;

namespace Assignment2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool exit = false;
            Menu menu = new Menu();
            Cart cart = new Cart();

            do
            {
                int option = menu.PrompOptions();
                menu.RunOption(option, cart);

            } while (!exit);
        } 
    }
}
