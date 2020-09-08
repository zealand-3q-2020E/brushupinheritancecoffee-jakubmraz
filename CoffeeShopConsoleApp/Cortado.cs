﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Cortado:Coffee, IMilk
    {
        public Cortado() : base()
        {

        }

        public Cortado(int discount, SpiceBlendEnum spiceBlend) : base(discount, spiceBlend)
        {
            this.SpiceBlend = spiceBlend;
            this.Discount = discount;
        }

        public int MlMilk()
        {
            return 40;
        }

        public override int Price()
        {
            return 25 - Discount;
        }

        public override string Strength()
        {
            return "Medium";
        }
    }
}
