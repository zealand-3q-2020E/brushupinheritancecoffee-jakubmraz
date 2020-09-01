using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Latte:Coffee, IMilk
    {
        public int MlMilk()
        {
            return 200;
        }

        public override int Price()
        {
            return 40;
        }

        public override string Strength()
        {
            return "Weak";
        }
    }
}
