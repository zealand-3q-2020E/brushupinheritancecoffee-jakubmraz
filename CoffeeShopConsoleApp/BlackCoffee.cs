using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class BlackCoffee : Coffee
    {
        public BlackCoffee(int discount, SpiceBlendEnum spiceBlend):base(discount, spiceBlend)
        {
            if (discount > 5)
            {
                throw new Exception();
            }

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
