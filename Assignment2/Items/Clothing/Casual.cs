using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Items.Clothing
{
    class Casual : Clothing
    {
        public enum Styles { DayWear = 1, NightWear, SwimWear }
        public Styles Style { get; set; } = new Styles();

        public Casual(Clothing clothing, Styles style) : base(clothing, clothing.Size)
        {
            Style = style;
        }

        public override string ToString()
        {
            return base.ToString() + "\n  - CASUAL Style: " + Style;
        }
    }
}
