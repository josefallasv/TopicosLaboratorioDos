using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab02.Logic;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Test1() //Potencia exitoso 1
        {
            double number = 10;
            double potency = 5;
            double expectedResult = 100000;
            double actualResult = Scientific.Potency(number,potency);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test2() //Potencia exitoso 2
        {
            double number = 99;
            double potency = 3;
            double expectedResult = 970299;
            double actualResult = Scientific.Potency(number, potency);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test3() //Potencia fallido 1
        {
            double number = 101;
            double potency = 2;
            double expectedResult = 10200;
            double actualResult = Scientific.Potency(number, potency);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test4() //Potencia fallido 2
        {
            double number = 1;
            double potency = 3;
            double expectedResult = 3;
            double actualResult = Scientific.Potency(number, potency);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test5() //Conversion dolares a colones exitoso 1
        {
            double usd = 10;
            double expectedResult = 5610;
            double actualResult = Financial.ConvertUSDtoCRC(usd);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test6() //Conversion dolares a colones exitoso 2
        {
            double usd = 1500;
            double expectedResult = 841500;
            double actualResult = Financial.ConvertUSDtoCRC(usd);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test7() //Conversion dolares a colones fallido 1
        {
            double usd = 1;
            double expectedResult = 500;
            double actualResult = Financial.ConvertUSDtoCRC(usd);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test8() //Conversion dolares a colones fallido 2
        {
            double usd = 0;
            double expectedResult = 1122;
            double actualResult = Financial.ConvertUSDtoCRC(usd);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test9() //Tangente exitoso 1
        {
            double number = 180;
            double expectedResult = 1;
            double actualResult = Scientific.TangentRadian(number);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test10() //Tangente exitoso 2
        {
            double number = 100;
            double expectedResult = -1;
            double actualResult = Scientific.TangentRadian(number);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test11() //Tangente fallido 1
        {
            double number = 100;
            double expectedResult = 2;
            double actualResult = Scientific.TangentRadian(number);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test12() //Tangente fallido 2
        {
            double number = 0;
            double expectedResult = -1;
            double actualResult = Scientific.TangentRadian(number);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
