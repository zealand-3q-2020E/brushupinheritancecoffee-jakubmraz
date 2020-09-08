using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class BlackCoffee : Coffee
    {
        public BlackCoffee() : base()
        {

        }

        public BlackCoffee(int discount, SpiceBlendEnum spiceBlend):base(discount, spiceBlend)
        {
            this.SpiceBlend = spiceBlend; 
            this.Discount = discount;
        }

        public override int Price()
        {
            return base.Price() - Discount;
        }

        public override string Strength()
        {
            return "Strong";
        }
    }
}
