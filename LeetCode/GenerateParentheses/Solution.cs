using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateParentheses
{
    public class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var list = new List<string>();
            BackTrack(list, "", 0, 0, n);
            return list;
        }

        private void BackTrack(IList<string> list, string str, int open, int close, int max) {
            if (str.Length == max * 2) {
                list.Add(str);
                return;
            }

            if (open < max) {
                BackTrack(list, str + "(", open + 1, close, max);
            }

            if(close < open)
            {
                BackTrack(list, str + ")", open, close + 1, max);
            }
        }


    }
}
