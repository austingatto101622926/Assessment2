using System;
using System.Collections.Generic;
using System.Text;
using Assignment2.Items;
using System.Linq;

namespace Assignment2
{
    public static class Cart
    {
        static public List<Item> Items { get; set; }  = new List<Item>();
        static public double Budget { get; set; } = 0;

        static public double CalculateTotal()
        {
            return Items.Select(x => x.Price).Sum();
        }

        static public void WriteCart()
        {
            int index = 1;
            foreach (Item cartItem in Cart.Items)
            {
                Console.WriteLine("Item " + index + ":\n" + cartItem.ToString());
                index++;
            }
        }

        static public void WriteBudget()
        {
            double total = CalculateTotal();
            Console.WriteLine("(" + total + "/" + Budget + ")");
            if (Budget == 0)
            {
                Console.WriteLine("TOTAL: $" + total);
            }
            else if (total > Budget)
            {
                Console.WriteLine("YOU ARE $" + Math.Abs(Budget - total) + " OVER YOUR BUDGET");
            }
            else
            {
                Console.WriteLine("YOU HAVE $" + (Budget-total) + " LEFT TO SPEND");
            }
        }

        static public bool OverBudget()
        {
            double total = CalculateTotal();
            if (total > Budget)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool OverBudget(double total, double budget)
        {
            if (total > Budget)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
