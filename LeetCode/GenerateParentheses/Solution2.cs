using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateParentheses
{
    public class Solution2
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var res = new List<List<string>>() { new List<string> { "" } };
            for (int i = 1; i <= n; i++)
            {
                res.Add(new List<string>());
                for (int j = 0; j < i; j++)
                {
                    var left = res[j];
                    var right = res[i - j - 1];

                    foreach (var front in left)
                    {
                        foreach (var back in right)
                        {
                            res[i].Add("(" + front + ")" + back);
                        }
                    }
                }
            }

            return res[n];
        }

    }
}
