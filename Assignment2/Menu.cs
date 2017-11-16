using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Menu
    {
        public string[] MenuOptions { get; set; }

        public Menu()
        {
            MenuOptions = new string[] 
            {
                "1. SET BUDGET",
                "2. VIEW CART",
                "3. ADD ITEM TO CART"
            };
        }

        public void RunOption(int option, Cart cart)
        {
            Console.Clear();
            switch (option)
            {
                case 1://1. SET BUDGET
                    if (cart.Budget == 0)
                    {
                        Console.WriteLine("--THE BUDGET HAS NOT BEEN SET--");
                    }
                    else
                    {
                        Console.WriteLine("--THE BUDGET IS CURRENTLY: "+cart.Budget+"--");
                    }
                    Console.WriteLine("--INPUT A BUDGET--");

                    bool inputValid = false;
                    double result = 0;

                    while (!inputValid)
                    {
                        string input = Console.ReadLine();
                        if (double.TryParse(input, out result))
                        {
                            if (result > 0)
                            {
                                inputValid = true;
                            }
                            else
                            {
                                Console.WriteLine("INPUT(" + input + ") CANNOT BE LESS THAN 0, TRY AGAIN");
                            }
                        }
                        else
                        {
                            Console.WriteLine("INPUT(" + input + ") INVALID, TRY AGAIN");
                        }
                    }
                    cart.Budget = result;
                    break;
                case 2://2. VIEW CART

                    break;
                case 3://3. ADD ITEM TO CART

                    break;
                default:
                    break;
            }
        }

        public int PrompOptions()
        {
            Console.Clear();
            Console.WriteLine("--SELECT A MENU OPTION--");
            foreach (string option in MenuOptions)
            {
                Console.WriteLine(option);
            }

            bool inputValid = false;
            int result = 0;
            while (!inputValid)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out result))
                {
                    if (result > 0 && result < MenuOptions.Length)
                    {
                        inputValid = true;
                    }
                    else
                    {
                        Console.WriteLine("INPUT(" + input + ") OUT OF BOUNDS, TRY AGAIN");
                    }
                }
                else
                {
                    Console.WriteLine("INPUT(" + input + ") INVALID, TRY AGAIN");
                }
            }
            return result;
        }
    }
}
