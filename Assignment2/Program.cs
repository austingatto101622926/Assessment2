using System;
using System.Collections.Generic;

namespace Assignment2
{
    class Program
    {
        static public bool Exit { get; set; } = false;

        static void Main(string[] args)
        {
            do
            {
                int option = Menu.PrompOptions();
                Menu.RunOption(option);

            } while (!Exit);
        } 
    }
}
