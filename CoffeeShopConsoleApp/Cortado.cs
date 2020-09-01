using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Cortado:Coffee, IMilk
    {
        public int MlMilk()
        {
            return 40;
        }

        public override int Price()
        {
            return 25;
        }

        public override string Strength()
        {
            return "Medium";
        }
    }
}
