using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202HappyNumber
{
    public class Solution
    {
        public bool IsHappy(int n)
        {
            int slow = n, fast = n;
            do
            {
                fast = SumDigitSquare(SumDigitSquare(fast));
                slow = SumDigitSquare(slow);
            } while (fast != 1 && fast != slow);
            

            return fast == 1;
        }

        private int SumDigitSquare(int n)
        {
            var sum = 0;
            while (n != 0)
            {
                var d = n % 10;
                n = n / 10;
                sum += d * d;
            }

            return sum;
        }
    }
}
