using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Items.Food
{
    class Food : Item
    {
        public double GrossWeight { get; set; }

        public Food(Item item, double grossWeight) : base(item.Name, item.Price)
        {
            GrossWeight = grossWeight;
        }

        public override string ToString()
        {
            return base.ToString() + "\n  - FOOD Gross Weight: " + GrossWeight;
        }
    }
}
