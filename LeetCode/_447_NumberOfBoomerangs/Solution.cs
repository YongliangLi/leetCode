using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfBoomerangs
{
    /*
     Given n points in the plane that are all pairwise distinct, a "boomerang" is a tuple of points (i, j, k) 
     such that the distance between i and j equals the distance between i and k (the order of the tuple matters).

    Find the number of boomerangs. You may assume that n will be at most 500 
    and coordinates of points are all in the range [-10000, 10000] (inclusive).

    Example:
    Input:
    [[0,0],[1,0],[2,0]]

    Output:
    2

    Explanation:
    The two boomerangs are [[1,0],[0,0],[2,0]] and [[1,0],[2,0],[0,0]]
         */
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
