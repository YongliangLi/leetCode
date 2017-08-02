using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPalindrome
{
    public class Solution
    {
        public int LongestPalindrome(string s)
        {
            var dict = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (dict.Keys.Contains(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict[c] = 1;
                }
            }

            int sumEven = 0;
            bool hasOdd = false;
            foreach (var k in dict.Keys)
            {
                if (dict[k] % 2 == 0)
                {
                    sumEven += dict[k];
                }
                else
                {
                    sumEven += dict[k] - 1;
                    hasOdd = true;
                }
            }
            return hasOdd ? sumEven + 1 : sumEven;
        }
    }
}
