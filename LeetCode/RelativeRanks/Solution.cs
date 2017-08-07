using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativeRanks
{
    public class Solution
    {
        public string[] FindRelativeRanks(int[] nums)
        {
            var pair = new int[nums.Length];
            var ret = new string[nums.Length];

            for (int i = 0; i < pair.Length; i++)
            {
                pair[i] = i ;
            }

            var compare = new ReverseComparer();
            Array.Sort(nums, pair, compare);
            for (int i = 0; i < nums.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        ret[pair[i]] = "Gold Medal";
                        break;
                    case 1:
                        ret[pair[i]] = "Silver Medal";
                        break;
                    case 2:
                        ret[pair[i]] = "Bronze Medal";
                        break;
                    default:
                        ret[pair[i]] = (i+1).ToString();
                        break;
                }
            }

            return ret;
        }

        public class ReverseComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                // Compare y and x in reverse order.
                return y.CompareTo(x);
            }
        }
    }
}
