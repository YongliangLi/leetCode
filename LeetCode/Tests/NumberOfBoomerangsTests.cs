using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests
{
    [TestClass]
    public class NumberOfBoomerangsTests
    {
        [TestMethod]
        public void NumberOfBoomerangsTests_TestMethod1()
        {
            var solution = new NumberOfBoomerangs.Solution();
            var points = new int[,]
            {
                {0,0 }, {1,0 }, {2,0 }
            };

            var ret = solution.NumberOfBoomerangs(points);
            Assert.AreEqual(2,ret);
        }
    }
}
