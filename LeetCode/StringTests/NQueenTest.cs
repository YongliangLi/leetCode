using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringTests
{
    [TestClass]
    public class NQueenTest
    {
        [TestMethod]
        public void NQueen_TestMethod1()
        {
            var solution = new NQueen.Solution();
            var list = solution.SolveNQueens(4);
        }
    }
}
