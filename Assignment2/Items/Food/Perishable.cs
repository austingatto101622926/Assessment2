using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Items.Food
{
    class Perishable : Food
    {
        public DateTime ExpiryDate { get; set; }
    }
}
