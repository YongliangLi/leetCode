using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringTests
{
    [TestClass]
    public class GenerateParenthesesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var s = new GenerateParentheses.Solution();
            var ret = s.GenerateParenthesis(3);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var s = new GenerateParentheses.Solution2();
            var ret = s.GenerateParenthesis(3);
        }
    }
}
