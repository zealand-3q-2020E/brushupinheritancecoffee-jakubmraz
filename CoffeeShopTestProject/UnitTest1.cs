using System;
using CoffeeShopConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoffeeShopTestProject
{
    [TestClass]
    public class UnitTest1
    {
        //[DataTestMethod]
        //[DataRow(1)]
        //[DataRow(0)]
        //[DataRow(-1)]
        //[DataRow(5)]
        //[DataRow(6)]
        //public void TestBlackCoffeePrice(int discount)
        //{
        //    //Arrange
        //    BlackCoffee blackCoffee = new BlackCoffee(discount, Coffee.SpiceBlendEnum.ESPRESSO);
        //    int expectedPrice = 20 - discount;
        //    //Act
        //    int price = blackCoffee.Price();
        //    //Assert
        //    if (discount < 6)
        //    {
        //        Assert.AreEqual(expectedPrice, price);
        //    }
        //    else Assert.Fail();
        //}

        [TestMethod]
        public void TestLattePrice()
        {
            //Arrange
            Latte latte = new Latte(0, Coffee.SpiceBlendEnum.ESPRESSO);
            //Act
            int price = latte.Price();
            //Assert
            Assert.AreEqual(40, price);
        }

        [TestMethod]
        public void TestCortadoStrength()
        {
            //Arrange
            Cortado cortado = new Cortado(0, Coffee.SpiceBlendEnum.ESPRESSO);
            //Act
            string strength = cortado.Strength();
            //Assert
            Assert.AreEqual("Medium", strength);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestExceptionOnHighDiscount()
        {
            //Arrange
            PumpkinSpiceLatte pumpkinSpiceLatte = new PumpkinSpiceLatte(6);
            //Act
            int price = pumpkinSpiceLatte.Price();
            //Assert
            Assert.AreEqual(64, price);
        }
    }
}
