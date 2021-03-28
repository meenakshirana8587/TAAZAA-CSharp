using CalculatorLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalcTest
{
    [TestClass]
    public class CalcTest
    {
        public Calculator c;

        private int num1;




        private int num2;

        private int addresult;

        private int diffresult;

        [TestInitialize]

        public void TestSeup()

        {

            c = new Calculator();

            num1 = 9;

            num2 = 2;

            addresult = 11;

            diffresult = 7;

        }





        [TestMethod]

        public void ShouldAddTwoPositiveNumbers()

        {

            var result = c.Add(num1, num2);

            Assert.AreEqual(addresult, result);

        }



        [TestMethod]

        public void ShouldReturnFirstNumberIfSecondNumberIsZero()

        {

            var result = c.Add(num1, 0);

            Assert.AreEqual(num1, result);

        }
        [TestMethod]

        public void ShouldSubTwoPositiveNumbers()

        {

            var result = c.Sub(num1, num2);

            Assert.AreEqual(diffresult, result);

        }

        [TestMethod]

        public void ShouldReturnNegativeSecondNumberIfFirstIsZeroNumbers()

        {

            var result = c.Sub(0, num2);

            Assert.AreEqual(-(num2), result);

        }
    }
}
