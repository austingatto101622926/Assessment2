using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Items.Clothing
{
    class Safety : Clothing
    {
        public enum Ratings {L = 1,M,H};
        public Ratings Rating { get; set; } = new Ratings();

        public Safety(Clothing clothing, Ratings rating) : base(clothing, clothing.Size)
        {
            Rating = rating;
        }
        public override string ToString()
        {
            return base.ToString() + "\n  - SAFTEY rating: " + Rating;
        }

    }
}
