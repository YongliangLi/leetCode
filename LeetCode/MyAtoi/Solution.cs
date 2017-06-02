using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAtoi
{
    public class Solution
    {
        /*
         How many ways to check int overflow?
         1. use check keyword to force throw OverflowException
         2. using long variable to save the value, then compare with int.MaxValue || int.MinValue
         3. compare with int.MaxValue ret > int.MaxValue/10 || (ret == int.MaxValue && n>7)
             
             */
        public int MyAtoi(string str)
        {
            var initialized = false;
            var sign = 1;
            var ret = 0;
            foreach (var c in str)
            {
                if (initialized == false && char.IsWhiteSpace(c)) continue;
                if (initialized == false && (c == '+' || c == '-'))
                {
                    initialized = true;
                    if (c == '-') sign = -1;
                    continue;
                }
                if (char.IsNumber(c) == false) return ret;

                if (initialized == false) initialized = true;
                var n = (int)char.GetNumericValue(c);
                try
                {
                    checked
                    {
                        ret = ret * 10 + n * sign;
                    }
                }
                catch (OverflowException)
                {
                    return sign > 0 ? int.MaxValue : int.MinValue;
                }
            }

            return ret;
        }
    }
}
