using AddNumbers2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedList.Tests
{
    [TestClass]
    public class AddTwoNumbers2Tests
    {
        private Solution sut = new Solution();

        [TestMethod]
        public void Should_Work_With_2ListNode_SameLength()
        {
            //arrange
            var l1 = BuildListNodeByArray(new int[] { 7, 2, 4, 3 });
            var l2 = BuildListNodeByArray(new int[] { 5, 6, 4 });

            //action
            var ret = sut.AddTwoNumbers(l1, l2);

            //assert
           Assert.IsTrue(AssertListedNode(ret, new int[] { 7, 8, 0, 7 }));
        }

        [TestMethod]
        public void Should_Work_With_2ListNode_DifferentLength()
        {
        }

        [TestMethod]
        public void Should_Work_With_2ListNode_OneIsNull()
        {
        }

        [TestMethod]
        public void Should_Work_With_2ListNode_TwoAreNull()
        {
        }

        private ListNode BuildListNodeByArray(int[] input)
        {
            var sentinal = new ListNode(0);
            var list = sentinal;
            foreach (var n in input)
            {
                list.next = new ListNode(n);
                list = list.next;
            }
            return sentinal.next;
        }

        private bool AssertListedNode(ListNode actual, int[] expected) {
            var p = actual;
            var idx = 0;
            while (p != null)
            {
                if (idx == expected.Length) return false;

                if (p.val != expected[idx++])
                {
                    return false;
                }
                p = p.next;
            }

            if (idx < expected.Length) return false;

            return true;
        }
    }
}
