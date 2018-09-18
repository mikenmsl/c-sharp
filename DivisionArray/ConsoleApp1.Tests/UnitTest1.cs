using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MyTest()
        {
            Arrays two = new Arrays();

            var arr = new[] { 1.0, 2, 3 };

            double[,] mainArray = two.Divide(arr, 3);
        }
    }
}
