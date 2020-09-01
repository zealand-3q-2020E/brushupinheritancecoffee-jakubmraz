using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class BlackCoffee : Coffee
    {
        public BlackCoffee(int discount):base(discount)
        {
            if (discount < 5)
            {
                throw new Exception();
            }

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
