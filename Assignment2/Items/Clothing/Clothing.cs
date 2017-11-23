using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Items.Clothing
{
    class Clothing : Item
    {
        public enum Sizes {S = 1,M,L,XL};
        public Sizes Size { get; set; }

        public Clothing(Item item, Sizes size) : base(item.Name, item.Price)
        {
            Size = size;
        }

        public override string ToString()
        {
            return base.ToString() + "\n  - CLOTHING Size: " + Size;
        }
    }
}
