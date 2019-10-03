using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsOdd()
        {
            bool result3 = Program.IsOdd(3);
            Assert.AreEqual(true, result3);

            bool result4 = Program.IsOdd(4);
            Assert.AreEqual(false, result4);
        }
        [TestMethod]
        public void TestIsEven()
        {
            bool result3 = Program.IsEven(3);
            Assert.AreEqual(false, result3);

            bool result4 = Program.IsEven(4);
            Assert.AreEqual(true, result4);
        }
        [TestMethod]
        public void TesIsPrime()
        {
            bool result0 = Program.IsPrime(0);
            Assert.AreEqual(false, result0);

            bool result1 = Program.IsPrime(1);
            Assert.AreEqual(false, result1);

            bool result2 = Program.IsPrime(2);
            Assert.AreEqual(true, result2);

            bool result3 = Program.IsPrime(3);
            Assert.AreEqual(true, result3);

            bool result4 = Program.IsPrime(4);
            Assert.AreEqual(false, result4);

            bool result5 = Program.IsPrime(-5);
            Assert.AreEqual(false, result5);
        }
        [TestMethod]
        public void TesSquare()
        {
            int result3 = Program.Square(3);
            Assert.AreEqual(9, result3);

            int result2 = Program.Square(2);
            Assert.AreEqual(4, result2);

            int resultnega2 = Program.Square(-2);
            Assert.AreEqual(4, resultnega2);
        }
        [TestMethod]
        public void TesCube()
        {
            int result3 = Program.Cube(3);
            Assert.AreEqual(27, result3);

            int result2 = Program.Cube(2);
            Assert.AreEqual(8, result2);

            int resultnega2 = Program.Cube(-2);
            Assert.AreEqual(-8, resultnega2);
        }
        [TestMethod]
        public void TesPow()
        {
            int result3 = Program.Pow(3, 3);
            Assert.AreEqual(27, result3);

            int result2 = Program.Pow(2, 3);
            Assert.AreEqual(8, result2);

            int resultnega2 = Program.Pow(-2, 3);
            Assert.AreEqual(-8, resultnega2);
        }
        [TestMethod]
        public void TestAbs()
        {
            int result3 = Program.Abs(3);
            Assert.AreEqual(3, result3);

            int resultnega4 = Program.Abs(-4);
            Assert.AreEqual(4, resultnega4);
        }
        [TestMethod]
        public void testCeil()
        {
            int kq1 = Program.Ceil(4.2);
            Assert.AreEqual(5, kq1);
            int kq2 = Program.Ceil(3);
            Assert.AreEqual(3, kq2);
            int kq3 = Program.Ceil(-5.6);
            Assert.AreEqual(-5, kq3);
        }
        [TestMethod]
        public void testFloor()
        {
            int kq1 = Program.Floor(4.2);
            Assert.AreEqual(4, kq1);
            int kq2 = Program.Floor(3);
            Assert.AreEqual(3, kq2);
            int kq3 = Program.Floor(-5.6);
            Assert.AreEqual(-6, kq3);


        }
        [TestMethod]
        

    }
}
