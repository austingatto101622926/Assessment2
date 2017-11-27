using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Items
{
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Price: $" + Price;
        }
    }
}
