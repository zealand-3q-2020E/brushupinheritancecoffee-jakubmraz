using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class PumpkinSpiceLatte : Coffee, IMilk
    {
        public PumpkinSpiceLatte(int discount, SpiceBlendEnum spiceBlend = SpiceBlendEnum.PUMPKIN) : base(discount, spiceBlend)
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
            return 250;
        }

        public override string Strength()
        {
            return "Weak";
        }

        public override int Price()
        {
            return 70;
        }
    }
}
