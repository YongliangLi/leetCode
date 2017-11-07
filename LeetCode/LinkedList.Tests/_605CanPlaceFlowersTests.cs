using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssert;

namespace LeetCode.Tests
{
    [TestClass]
    public class _605CanPlaceFlowersTests
    {
        [TestMethod]
        public void Basic_Positive()
        {
            int[] flowerbed = new[] { 1, 0, 0, 0, 1 };
            int target = 1;

            var solution = new _605CanPlaceFlowers.Solution();
            var ret = solution.CanPlaceFlowers(flowerbed, target);

            Assert.AreEqual(true, ret);
        }

        [TestMethod]
        public void Basic_Negative()
        {
            int[] flowerbed = new[] { 0, 1, 0};
            int target = 1;

            var solution = new _605CanPlaceFlowers.Solution();
            var ret = solution.CanPlaceFlowers(flowerbed, target);

            Assert.AreEqual(false, ret);
        }


        [TestMethod]
        public void Basic_Skip_1()
        {
            int[] flowerbed = new[] { 0, 0, 0 };
            int target = 1;

            var solution = new _605CanPlaceFlowers.Solution();
            var ret = solution.CanPlaceFlowers(flowerbed, target);

            Assert.AreEqual(true, ret);
        }
    }
}
