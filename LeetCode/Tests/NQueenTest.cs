using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedList.Tests
{
    [TestClass]
    public class NQueenTest
    {
        [TestMethod]
        public void NQueen_solution1A_size_4()
        {
            var solution = new NQueen.Solution1A();
            var list = solution.SolveNQueens(4);
        }

        [TestMethod]
        public void NQueen_solution1_size_4()
        {
            var solution = new NQueen.Solution1();
            var list = solution.SolveNQueens(4);
        }
        [TestMethod]
        public void NQueen_solution1_size_8()
        {
            var solution = new NQueen.Solution1();
            var list = solution.SolveNQueens(4);
        }
        [TestMethod]
        public void NQueen_solution1_size_16()
        {
            var solution = new NQueen.Solution1();
            var list = solution.SolveNQueens(4);
        }

        [TestMethod]
        public void NQueen_solution2_size_4()
        {
            var solution = new NQueen.Solution2();
            var list = solution.SolveNQueens(4);
        }
        [TestMethod]
        public void NQueen_solution2_size_8()
        {
            var solution = new NQueen.Solution2();
            var list = solution.SolveNQueens(4);
        }
        [TestMethod]
        public void NQueen_solution2_size_16()
        {
            var solution = new NQueen.Solution2();
            var list = solution.SolveNQueens(4);
        }

        [TestMethod]
        public void NQueen_solution3_size_4()
        {
            var solution = new NQueen.Solution3();
            var list = solution.SolveNQueens(4);
        }
    }
}
