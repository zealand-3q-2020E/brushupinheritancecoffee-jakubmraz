using System;
using CoffeeShopConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoffeeShopTestProject
{
    [TestClass]
    public class UnitTest1
    {
        #region CoffeeTest

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

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(6)]
        [ExpectedException(typeof(ArgumentException))]
        public void TestExceptionOnHighDiscount(int discount)
        {
            //Arrange
            PumpkinSpiceLatte pumpkinSpiceLatte = new PumpkinSpiceLatte(discount);
            //Act
            int price = pumpkinSpiceLatte.Price();
            //Assert
            Assert.AreEqual(64, price);
        }

        [DataTestMethod]
        [DataRow(0, 20)]
        [DataRow(1, 19)]
        [DataRow(2, 18)]
        [DataRow(3, 17)]
        [DataRow(4, 16)]
        [DataRow(5, 15)]
        public void TestDiscountPrice(int discount, int expectedPrice)
        {
            //Arrange
            var coffee = new BlackCoffee(discount, Coffee.SpiceBlendEnum.ESPRESSO);
            //Act
            int actualPrice = coffee.Price();
            //Assert
            Assert.AreEqual(expectedPrice, actualPrice);
        }

        #endregion
    }
}
