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
        public enum SpiceBlendEnum{ KIRITE, ESPRESSO, KIENI, PUMPKIN }

        //Empty constructor with default values to put into the constructor with parameters
        public Coffee():this(0, SpiceBlendEnum.ESPRESSO)
        {

        }

        public Coffee(int discount, SpiceBlendEnum spiceBlend)
        {
            this.Discount = discount;
            this.SpiceBlend = spiceBlend;
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

        public SpiceBlendEnum SpiceBlend { get; set; }
    }
}
