using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercise01;

namespace Example01Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOnes()
        {
            //arrange
            long num = 1;
            //act
            var stringValue = num.Towards();
            var expectedValue = "One";
            //assert
            Assert.AreEqual(expectedValue, stringValue);
        }

        [TestMethod]
        public void TestTens()
        {
            //arrange
            long num = 16;
            //act
            var stringValue = num.Towards();
            var expectedValue = "Sixteen";
            //assert
            Assert.AreEqual(expectedValue, stringValue);
        }

 

        [TestMethod]
        public void TestThousands()
        {
            //arrange
            long num = 1567;

            //act
            var stringValue = num.Towards();
            var expectedValue = "One Thousand Five Hundred Sixty Seven";
            //assert
            Assert.AreEqual(expectedValue, stringValue);
        }

        [TestMethod]
        public void TestMillions()
        {
            //arrange
            long num = 18000000;

            //act
            var stringValue = num.Towards();
            var expectedValue = "Eighteen Million";
            //assert
            Assert.AreEqual(expectedValue, stringValue);
        }

        [TestMethod]
        public void TestQuintillion()
        {
            //arrange
            long num = 18456002032011000007;

            //act
            var stringValue = num.Towards();
            var expectedValue = "Eighteen Quintillion, Four Hundred Fifty Six Quadrillion Two Trillion, Thirty Two Billion Eleven Million Seven";
            //assert
            Assert.AreEqual(expectedValue, stringValue);
        }
    }
}
