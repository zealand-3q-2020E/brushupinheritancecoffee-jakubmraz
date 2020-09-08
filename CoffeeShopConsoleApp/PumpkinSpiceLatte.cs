using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class PumpkinSpiceLatte : Coffee, IMilk
    {
        public PumpkinSpiceLatte() : base()
        {
            this.SpiceBlend = SpiceBlendEnum.PUMPKIN;
        }

        public PumpkinSpiceLatte(int discount, SpiceBlendEnum spiceBlend = SpiceBlendEnum.PUMPKIN) : base(discount, spiceBlend)
        {
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
