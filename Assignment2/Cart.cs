using System;
using System.Collections.Generic;
using System.Text;
using Assignment2.Items;

namespace Assignment2
{
    class Cart
    {
        public List<Item> Items { get; set; }
        public double Budget { get; set; }

        public Cart()
        {
            Items = new List<Item>();
            Budget = 0;
        }
    }
}
