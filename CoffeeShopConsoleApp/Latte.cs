using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Latte:Coffee, IMilk
    {
        public Latte(int discount) : base(discount)
        {
            if (discount < 5)
            {
                throw new Exception();
            }

            this.Discount = discount;
        }

        public int MlMilk()
        {
            return 200;
        }

        public override int Price()
        {
            if (Discount < 5)
            {
                throw new Exception();
            }

            return 40 - Discount;
        }

        public override string Strength()
        {
            return "Weak";
        }
    }
}
