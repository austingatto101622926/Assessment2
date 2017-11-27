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
            Cart.Items.Add(new Item("a", 10));
            Cart.Items.Add(new Item("b", 33));
            Cart.Items.Add(new Item("c", 18));
            Cart.Items.Add(new Item("d", 5));

            expected = 10 + 33 + 18 + 5; //
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
            total = 100;
            budget = 20;

            expected = (total > budget);
            actual = Cart.OverBudget(total, budget);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
