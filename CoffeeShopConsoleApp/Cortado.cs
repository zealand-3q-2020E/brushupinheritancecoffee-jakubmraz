using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Cortado:Coffee, IMilk
    {
        public Cortado(int discount) : base(discount)
        {
            if (discount < 5)
            {
                throw new Exception();
            }
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
