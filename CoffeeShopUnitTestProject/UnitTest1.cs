using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coffee

namespace CoffeeShopUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(BlackCoffee)]
        public void TestPrice(Cofffee coffee)
        {
        }
    }
}
