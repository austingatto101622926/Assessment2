using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Items.Clothing
{
    class Casual : Clothing
    {
        public enum Styles { DayWear, NightWear, SwimWear }
        public Styles Style { get; set; }
    }
}
