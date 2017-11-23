using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Items.Food
{
    class NonPerishable : Food  
    {
        public double NetWeight { get; set; }

        public NonPerishable(Food food, double netWeight) : base(food, food.GrossWeight)
        {
            NetWeight = netWeight;
        }
        public override string ToString()
        {
            return base.ToString() + "\n  - NON-PERISHABLE Net Weight: " + NetWeight;
        }
    }
}
