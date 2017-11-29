using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Items.Food
{
    class Perishable : Food
    {
        public DateTime ExpiryDate { get; set; }

        public Perishable(Food food, DateTime expiryDate) : base(food, food.GrossWeight)
        {
            ExpiryDate = expiryDate;
        }

        public override string ToString()
        {
            return base.ToString() + "\n  - PERISHABLE Expiry Date: " + ExpiryDate.ToString("yyyy-MM-dd");
        }
    }
}
