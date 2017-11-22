using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
    public class Solution
    {
        /*
         Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

        The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
             */

        /*
         1. Dictionary initialize
         2. Stack Push, Pop, Count             
             */

        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            var hs = new Dictionary<char, char>(){
                {'}','{'},
                { ']','['},
                { ')',')'}
            };

            foreach (var c in s)
            {
                if (hs.Keys.Contains(c))
                {
                    if (hs[c] != stack.Pop()) return false;
                }
                else
                {
                    stack.Push(c);
                }
            }

            return stack.Count == 0;

        }
    }
}
