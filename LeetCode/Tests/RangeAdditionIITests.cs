using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests
{
    [TestClass]
    public class RangeAdditionIITests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int m = 26, n = 17;
            var ops = new[,] { { 20, 10 }, { 26, 11 }, { 2, 11 }, { 4, 16 }, { 2, 3 }, { 23, 13 }, { 7, 15 }, { 11, 11 }, { 25, 13 }, { 11, 13 }, { 13, 11 }, { 13, 16 }, { 26, 17 } };
            RangeAdditonII.Solution solution = new RangeAdditonII.Solution();
            var count = solution.MaxCount(m, n, ops);
            Assert.AreEqual(6, count);

        }
    }
}
