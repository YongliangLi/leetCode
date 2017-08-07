using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfBoomerangs
{
    public class Solution
    {
        public int NumberOfBoomerangs(int[,] points)
        {
            var hs = new Dictionary<int, int>();
            var ret = 0;
            for (int i = 0; i < points.GetLength(0); i++)
            {
                for (int j = 0; j < points.GetLength(0); j++)
                {
                    if (i == j) continue;

                    var dist = GetDistance(new int[] { points[i, 0], points[i, 1] }, new int[] { points[j, 0], points[j, 1] });
                    hs[dist] = hs.Keys.Contains(dist) ? hs[dist] + 1 : 1;
                }

                foreach (var val in hs.Values)
                {
                    ret += val * (val - 1);
                }
                hs.Clear();
            }

            return ret;
        }

        private int GetDistance(int[] a, int[] b)
        {
            int dx = a[0] - b[0];
            int dy = a[1] - b[1];

            return dx * dx + dy * dy;
        }
    }
}
