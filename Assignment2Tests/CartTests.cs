using Assignment2;
using Assignment2.Items;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Assignment2Tests
{
    [TestClass]
    public class CartTests
    {
        [TestMethod]
        public void CalculateTotal_Test()
        {
            //Arrange
            double expected;
            double actual;

            //Act
            Cart.Items.Add(new Item("a", 35.5));
            Cart.Items.Add(new Item("b", 0.05));

            expected = 35.55;
            actual = Cart.CalculateTotal();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void OverBudget_Test()
        {
            //Arrange
            double total;
            double budget;

            bool expected;
            bool actual;

            //Act
            total = 99;
            budget = 100;

            expected = false;  // (total>budget);
            actual = Cart.OverBudget(total, budget);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
