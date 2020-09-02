using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Latte:Coffee, IMilk
    {
        public Latte(int discount, SpiceBlendEnum spiceBlend) : base(discount, spiceBlend)
        {
            if (discount > 5)
            {
                throw new Exception();
            }

            this.SpiceBlend = spiceBlend;
            this.Discount = discount;
        }

        public int MlMilk()
        {
            return 200;
        }

        public override int Price()
        {

            return 40 - Discount;
        }

        public override string Strength()
        {
            return "Weak";
        }
    }
}
