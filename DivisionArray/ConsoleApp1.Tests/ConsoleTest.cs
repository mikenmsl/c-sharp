using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1.Tests
{
    [TestClass]
    public class ConsoleTest
    {
        [TestMethod]
        public void SizeOfList()
        {
            List<double> primary = new List<double>();
            primary.Add(5);
            primary.Add(8);
            primary.Add(8.5);
            Assert.AreEqual(3, primary.Count);
        }
        [TestMethod]
        public void DividedListAndSum()
        {
            double[] first = { 1, 3, 0};
            double[] second = { 2, 4 };
            List<double> primary = new List<double>();
            primary.Add(1);
            primary.Add(2);
            primary.Add(3);
            primary.Add(4);
            DivideByIndex div = new DivideByIndex();
            double[] arr1 = div.Even(primary);
            double[] arr2 = div.Odd(primary);
            CountSum sum = new CountSum();
            double ans1 = sum.ReturnSum(arr1);
            double ans2 = sum.ReturnSum(arr2);
            Assert.AreEqual(4, ans1);
            Assert.AreEqual(6, ans2);
        }
        [TestMethod]
        public void Size()
        {
            List<double> primary = new List<double>();
            primary.Add(5);
            primary.Add(8);
            primary.Add(8.5);
            Assert.AreEqual(-1, primary.Count);
        }
        public void DividedList()
        {
            double[] first = { 1, 3 };
            double[] second = { 2, 4 };
            List<double> primary = new List<double>();
            primary.Add(1);
            primary.Add(0);
            primary.Add(3);
            primary.Add(4);
            DivideByIndex div = new DivideByIndex();
            double[] arr1 = div.Even(primary);
            double[] arr2 = div.Odd(primary);
            Assert.AreEqual(first, arr1);
            Assert.AreEqual(second, arr2);
        }
    }
}
