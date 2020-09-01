using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffe orders
    /// </summary>
    public abstract class Coffee
    {
        public Coffee(int discount)
        {
            this.Discount = discount;
        }

        /// <summary>
        /// returns the Price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>
        public virtual int Price()
        {
            //No need to apply the discount here since you can't create a coffee object
            return 20;
        }

        public abstract string Strength();

        public int Discount { get; set; }

    }
}
