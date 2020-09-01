using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new BlackCoffee(3, Coffee.SpiceBlendEnum.ESPRESSO),
                new Cortado(4, Coffee.SpiceBlendEnum.KIENI),
                new Latte(0, Coffee.SpiceBlendEnum.KIRITE),
                new PumpkinSpiceLatte(0)

            };

            List<IMilk> milkedCoffeeList = new List<IMilk>()
            {
                new Cortado(2, Coffee.SpiceBlendEnum.ESPRESSO),
                new Latte(1, Coffee.SpiceBlendEnum.KIRITE),
                new Latte(4, Coffee.SpiceBlendEnum.ESPRESSO),
                new PumpkinSpiceLatte(5)
            };

            foreach (var coffee in orderList)
            {
                Console.WriteLine("The Price of the coffee is: "+ coffee.Price() + "kr and its spice blend is " + coffee.SpiceBlend);
            }

            foreach (var coffee in milkedCoffeeList)
            {
                Console.WriteLine("The amount of milk in this coffee is: " + coffee.MlMilk());
            }

        }
    }
}
