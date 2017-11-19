using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNumbers2
{

    /**
     You are given two non-empty linked lists representing two non-negative integers. 
        The digits are stored in reverse order and each of their nodes contain a single digit. 
        Add the two numbers and return it as a linked list.

    You may assume the two numbers do not contain any leading zero, except the number 0 itself.

    Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    Output: 7 -> 0 -> 8
        */

    /**
      * Definition for singly-linked list.
      * public class ListNode {
      *     public int val;
      *     public ListNode next;
      *     public ListNode(int x) { val = x; }
      * }
      */
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var stack1 = new Stack<int>();
            var stack2 = new Stack<int>();
            var h1 = l1;
            var h2 = l2;
            while (h1 != null)
            {
                stack1.Push(h1.val);
                h1 = h1.next;
            }
            while (h2 != null)
            {
                stack2.Push(h2.val);
                h2 = h2.next;
            }

            var sum = 0;            
            ListNode c=null,n=null;
            while (stack1.Count > 0 || stack2.Count > 0 || sum >= 10)
            {
                sum = sum / 10;
                if (stack1.Count > 0)
                {
                    sum += stack1.Pop();
                }
                if (stack2.Count > 0)
                {
                    sum += stack2.Pop();
                }

                c = new ListNode(sum % 10)
                {
                    next = n
                };
                n = c;
            }

            return c;

        }
    }
}
