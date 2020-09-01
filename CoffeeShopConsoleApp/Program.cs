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
                new BlackCoffee(3),
                new Cortado(4),
                new Latte(0)

            };

            List<IMilk> milkedCoffeeList = new List<IMilk>()
            {
                new Cortado(2),
                new Latte(1),
                new Latte(4)
            };

            foreach (var coffee in orderList)
            {
                Console.WriteLine("the Price of the coffee is : "+ coffee.Price());
            }


        }
    }
}
