using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOfLongestSubstring
{
    /*
     3. Longest Substring Without Repeating Characters
     Given a string, find the length of the longest substring without repeating characters.

Examples:

Given "abcabcbb", the answer is "abc", which the length is 3.

Given "bbbbb", the answer is "b", with the length of 1.

Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
         
         */
    public class Solution1
    {
        public int LengthOfLongestSubstring(string s)
        {
            var i = 0;
            var j = 0;
            var ans = 0;
            var set = new HashSet<char>();
            var n = s.Length;
            while (i < n && j < n)
            {
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j++]);
                    ans = Math.Max(ans, j - i);
                }
                else
                {
                    set.Remove(s[i++]);
                }
            }

            return ans;
        }
    }
}
