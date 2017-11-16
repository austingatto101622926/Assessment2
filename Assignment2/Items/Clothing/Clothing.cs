using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Items.Clothing
{
    class Clothing : Item
    {
        public enum Sizes {S,M,L,XL};
        public Sizes Size { get; set; }
    }
}
