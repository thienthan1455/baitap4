using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsContain5()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4, 5 };
            bool kq1 = Program.IsContain5(Arr1);
            Assert.AreEqual(true, kq1);

            int[] Arr2 = new int[] { 1, 2, 3, 4, 6 };
            bool kq2 = Program.IsContain5(Arr2);
            Assert.AreEqual(false, kq2);

            int[] Arr3 = new int[0]; 
            bool kq3 = Program.IsContain5(Arr3);
            Assert.AreEqual(false, kq3);
        }
         [TestMethod]
        public void TestIsContain5or6()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
            bool kq1 = Program.IsContain5or6(Arr1);
            Assert.AreEqual(true, kq1);

            int[] Arr2 = new int[] { 1, 2, 3, 4, 6 };
            bool kq2 = Program.IsContain5or6(Arr2);
            Assert.AreEqual(true, kq2);

            int[] Arr3 = new int[] { 1, 2, 3, 4, 7 };
            bool kq3 = Program.IsContain5or6(Arr3);
            Assert.AreEqual(false, kq3);

           
        }
         [TestMethod]
        public void TestIsContain5and6()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
            bool kq1 = Program.IsContain5and6(Arr1);
            Assert.AreEqual(true, kq1);

            int[] Arr2 = new int[] { 1, 2, 3, 4, 6 };
            bool kq2 = Program.IsContain5and6(Arr2);
            Assert.AreEqual(false, kq2);

            int[] Arr3 = new int[] { 1, 2, 3, 4, 7 };
            bool kq3 = Program.IsContain5and6(Arr3);
            Assert.AreEqual(false, kq3);

           
        }
         [TestMethod]
        public void TestCount5()
         {
             int[] Arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
             int kq1 = Program.Count5(Arr1);
             Assert.AreEqual(1, kq1);

             int[] Arr2 = new int[] { 1, 2, 3, 4, 6 };
             int kq2 = Program.Count5(Arr2);
             Assert.AreEqual(0, kq2);

         }
         [TestMethod]
         public void TestCount5or6()
         {
             int[] Arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
             int kq1 = Program.Count5or6(Arr1);
             Assert.AreEqual(2, kq1);

             int[] Arr2 = new int[] { 1, 2, 3, 4, 6 };
             int kq2 = Program.Count5or6(Arr2);
             Assert.AreEqual(1, kq2);

         }
          [TestMethod]
        public void TestSum()
         {
             int[] Arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
             int kq1 = Program.Sum(Arr1);
             Assert.AreEqual(21, kq1);

             int[] Arr2 = new int[] { 1, 2, 3, 4, 6 };
             int kq2 = Program.Sum(Arr2);
             Assert.AreEqual(16, kq2);

            
            int[] Arr3 = new int[0];
            int kq3 = Program.Sum(Arr3);
            Assert.AreEqual(0, kq3);
         }
    }
}
