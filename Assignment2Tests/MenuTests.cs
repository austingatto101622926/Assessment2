using Assignment2;
using Assignment2.Items;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;


namespace Assignment2Tests
{
    [TestClass]
    public class MenuTests
    {
        [TestMethod]
        public void ReadValidSelection_Test()
        {
            //Arrange
            int min;
            int max;
            string input;

            StringReader stringReader;

            int expected;
            int actual;

            //Act
            min = 1;
            max = 10;
            input = "10";

            stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            expected = 10;
            actual = Menu.ReadValidSelection(min, max);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ReadValidPrice_Test()
        {
            //Arrange
            string input;

            double expected;
            double actual;

            StringReader stringReader;

            //Act
            input = "11";

            stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            expected = 11;
            actual = Menu.ReadValidPrice();

            //Assert
            Assert.AreEqual(expected,actual);

        }

        [TestMethod]
        public void ReadValidDate_Test()
        {
            //Arrange
            string input;

            DateTime expected;
            DateTime actual;

            StringReader stringReader;

            //Act
            input = "2017-09-14";

            stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            expected = new DateTime(2017,09,14);
            actual = Menu.ReadValidDate();

            //Assert
            Assert.AreEqual(expected, actual);


        }
    }
}
