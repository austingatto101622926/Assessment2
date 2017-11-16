using System;
using System.Collections.Generic;
using System.Text;
using Assignment2.Items;
using Assignment2.Items.Clothing;
using Assignment2.Items.Food;

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
                        Console.WriteLine("--THE BUDGET IS CURRENTLY: $"+cart.Budget+"--");
                    }
                    Console.WriteLine("--INPUT A BUDGET--");
                    cart.Budget = ReadValidPrice();
                    break;
                case 2://2. VIEW CART

                    break;
                case 3://3. ADD ITEM TO CART
                    Console.WriteLine("--DD ITEM TO CART--");

                    Console.WriteLine("WHAT IS THE NAME OF YOUR ITEM:");
                    string name = Console.ReadLine();
                    Console.WriteLine("WHAT IS THE PRICE OF YOUR ITEM:");
                    double price = ReadValidPrice();

                    Console.WriteLine("IS YOUR ITEM:");
                    Console.WriteLine("\t1. CLOTHING \n\t2. FOOD");
                    int selection = ReadValidSelection(1,2);
                    if (selection == 1)
                    {
                        Console.WriteLine("IS YOUR CLOTHING SIZE:");
                        Console.WriteLine("\t1. S\n\t2. M\n\t3. L\n\t4. XL");
                        int size = ReadValidSelection(1, 4);

                        Console.WriteLine("IS YOUR CLOTHING FOR:");
                        Console.WriteLine("\t1. SAFTEY \n\t2. CASUAL");
                        selection = ReadValidSelection(1, 2);
                        if (selection == 1)
                        {
                            Console.WriteLine("WHAT IS THE SAFTEY RATING OF YOUR CLOTHING:");
                            Console.WriteLine("\t1. L\n\t2. M\n\t3. H");
                            int safteyRating = ReadValidSelection(1,3);
                        }
                        else if (selection == 2)
                        {
                            Console.WriteLine("WHAT IS THE STYLE OF YOUR CLOTHING:");
                            Console.WriteLine("\t1. Day Wear\n\t2. Night Wear\n\t3. Swim Wear");
                            int style = ReadValidSelection(1, 3);
                        }
                    }
                    else if (selection == 2)
                    {

                    }



                    Console.ReadLine();
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

            return ReadValidSelection(1, MenuOptions.Length);
        }

        int ReadValidSelection(int min, int max)
        {
            bool inputValid = false;
            int result = 0;
            while (!inputValid)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out result))
                {
                    if (result >= min && result <= max)
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

         double ReadValidPrice()
        {
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
            return result;
        }
    }
}
