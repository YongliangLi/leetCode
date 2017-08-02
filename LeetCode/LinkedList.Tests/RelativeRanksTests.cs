using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedList.Tests
{
    [TestClass]
    public class RelativeRanksTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var nums = new int[] { 10, 3, 8, 9, 4 };

            var solution = new RelativeRanks.Solution();
            var result = solution.FindRelativeRanks(nums);

        }
    }
}
