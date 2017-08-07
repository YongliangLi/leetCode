using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeAdditonII
{
    public class Solution
    {
        public int MaxCount(int m, int n, int[,] ops)
        {
            int x = m, y = n;
            for (int i = 0; i < ops.GetLength(0); i++)
            {
                x = Math.Min(x, ops[i, 0]);
                y = Math.Min(y, ops[i, 1]);

            }        

            return x * y;

        }
    }
}
