using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Items.Clothing
{
    class Safety : Clothing
    {
        public enum Ratings {L,M,H};
        public Ratings Rating { get; set; }
    }
}
