using System;
using System.Collections.Generic;
using System.Text;
using Assignment2.Items;
using Assignment2.Items.Clothing;
using Assignment2.Items.Food;

namespace Assignment2
{
    static class Menu
    {
        static public string[] MenuOptions { get; set; }

        static Menu()
        {
            MenuOptions = new string[] 
            {
                "1. SET BUDGET",
                "2. VIEW CART",
                "3. ADD ITEM TO CART",
                "4. REMOVE ITEM FROM CART",
                "\n5. EXIT"
            };
        }

        static public void RunOption(int option)
        {
            Console.Clear();
            switch (option)
            {
                case 1://1. SET BUDGET

                    if (Cart.Budget == 0)
                    {
                        Console.WriteLine("--THE BUDGET HAS NOT BEEN SET--");
                    }
                    else
                    {
                        Console.WriteLine("--THE BUDGET IS CURRENTLY: $"+ Cart.Budget+"--");
                    }
                    Console.WriteLine("--INPUT A BUDGET--");
                    Cart.Budget = ReadValidPrice();
                    break;

                case 2://2. VIEW CART

                    Console.WriteLine("--VIEW CART--");
                    Cart.WriteCart();

                    Console.WriteLine("\n--BUDGET INFORMATION--");
                    Cart.WriteBudget();

                    Console.WriteLine("\nPRESS ENTER TO CONTINUE");
                    Console.ReadLine();
                    break;

                case 3://3. ADD ITEM TO CART

                    Console.WriteLine("--ADD ITEM TO CART--");

                    //BASE ITEM PROPERTIES
                    Console.WriteLine("WHAT IS THE NAME OF YOUR ITEM:");
                    string name = Console.ReadLine();
                    Console.WriteLine("WHAT IS THE PRICE OF YOUR ITEM:");
                    double price = ReadValidPrice();

                    Item item = new Item(name, price);//SET ITEM PROPERTIES

                    Console.WriteLine("IS YOUR ITEM:");
                    Console.WriteLine("\t1. CLOTHING \n\t2. FOOD \n\t3. OTHER");
                    int selection = ReadValidSelection(1,3);
                    //BASE CLOTHING PROPERTIES
                    if (selection == 1)
                    {
                        Console.WriteLine("IS YOUR CLOTHING SIZE:");
                        Console.WriteLine("\t1. S\n\t2. M\n\t3. L\n\t4. XL");
                        int size = ReadValidSelection(1, 4);

                        Clothing clothing = new Clothing(item, (Clothing.Sizes)size);//SET CLOTHING PROPERTIES

                        Console.WriteLine("IS YOUR CLOTHING FOR:");
                        Console.WriteLine("\t1. SAFTEY \n\t2. CASUAL");
                        selection = ReadValidSelection(1, 2);
                        //SAFTEY CLOTHING PROPERTIES
                        if (selection == 1)
                        {
                            Console.WriteLine("WHAT IS THE SAFTEY RATING OF YOUR CLOTHING:");
                            Console.WriteLine("\t1. L\n\t2. M\n\t3. H");
                            int safteyRating = ReadValidSelection(1,3);

                            item = new Safety(clothing, (Safety.Ratings)safteyRating);//SET SAFTEY PROPERTIES
                        }
                        //CASUAL CLOTHING PROPERTIES
                        else if (selection == 2)
                        {
                            Console.WriteLine("WHAT IS THE STYLE OF YOUR CLOTHING:");
                            Console.WriteLine("\t1. Day Wear\n\t2. Night Wear\n\t3. Swim Wear");
                            int style = ReadValidSelection(1, 3);

                            item = new Casual(clothing, (Casual.Styles)style);//SET CASUAL PROPERTIES
                        }
                    }
                    //BASE FOOD PROPERTIES
                    else if (selection == 2)
                    {
                        Console.WriteLine("WHAT IS YOUR FOODS GROSS WEIGHT:");
                        double grossWeight = ReadValidPrice();

                        Food food = new Food(item, grossWeight);//SET FOOD PROPERTIES

                        Console.WriteLine("IS YOUR FOOD ITEM:");
                        Console.WriteLine("\t1. PERISHABLE \n\t2. NON_PERISHABLE");
                        selection = ReadValidSelection(1, 2);
                        //PERISHABLE FOOD PROPERTIES
                        if (selection == 1)
                        {
                            Console.WriteLine("WHAT IS THE EXPIRY DATE OF YOUR FOOD(yyyy-mm-dd):");
                            DateTime expiryDate = ReadValidDate();

                            item = new Perishable(food, expiryDate);//SET PERISHABLE PROPERTIES
                        }
                        //NON-PERISHABLE FOOD PROPERTIES
                        else if (selection == 2)
                        {
                            Console.WriteLine("WHAT IS THE NET WEIGHT OF YOU FOOD:");
                            double netWeight = ReadValidPrice();

                            item = new NonPerishable(food, netWeight);//SET NON-PERISHABLE PROPERTIES
                        }
                    }

                    Cart.Items.Add(item);
                    Console.Clear();
                    Console.WriteLine("YOU HAVE ADDED THE FOLLOWING ITEM TO THE CART:");
                    Console.WriteLine(item.ToString());

                    Console.WriteLine("\nPRESS ENTER TO CONTINUE");
                    Console.ReadLine();
                    break;

                case 4:

                    if (Cart.Items.Count == 0)
                    {
                        Console.WriteLine("YOUR CART IS EMPTY");

                        Console.WriteLine("\nPRESS ENTER TO CONTINUE");
                        Console.ReadLine();
                        break;
                    }

                    Console.WriteLine("--YOUR CART--");
                    Cart.WriteCart();

                    Console.WriteLine("--SELECT AN ITEM TO REMOVE--");
                    int index = ReadValidSelection(1,Cart.Items.Count)-1;
                    Cart.Items.RemoveAt(index);

                    Console.WriteLine("\nPRESS ENTER TO CONTINUE");
                    Console.ReadLine();
                    break;

                case 5:
                    Program.Exit = true;
                    break;
                default:
                    break;
            }
        }

        static public int PrompOptions()
        {
            Console.Clear();
            Console.WriteLine("--SELECT A MENU OPTION--");
            foreach (string option in MenuOptions)
            {
                Console.WriteLine(option);
            }

            return ReadValidSelection(1, MenuOptions.Length);
        }

        static int ReadValidSelection(int min, int max)
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

         static double ReadValidPrice()
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

        static DateTime ReadValidDate()
        {
            bool inputValid = false;
            DateTime result = new DateTime();

            while (!inputValid)
            {
                string input = Console.ReadLine();
                if (!DateTime.TryParse(input, out result))
                {
                    Console.WriteLine("INPUT(" + input + ") INVALID, TRY AGAIN");
                }
                else
                {
                    inputValid = true;
                }
            }
            return result;
        }
    }
}
