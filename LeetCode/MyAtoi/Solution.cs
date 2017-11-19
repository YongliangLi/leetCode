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
         Implement atoi to convert a string to an integer.

        Hint: Carefully consider all possible input cases. If you want a challenge, please do not see below and ask yourself what are the possible input cases.

        Notes: It is intended for this problem to be specified vaguely (ie, no given input specs). You are responsible to gather all the input requirements up front.

        Update (2015-02-10):
        The signature of the C++ function had been updated. If you still see your function signature accepts a const char * argument, 
        please click the reload button  to reset your code definition.

        spoilers alert... click to show requirements for atoi.

        Requirements for atoi:
        The function first discards as many whitespace characters as necessary until the first non-whitespace character is found. 
        Then, starting from this character, takes an optional initial plus or minus sign followed by as many numerical digits as possible, 
        and interprets them as a numerical value.

        The string can contain additional characters after those that form the integral number, 
        which are ignored and have no effect on the behavior of this function.

        If the first sequence of non-whitespace characters in str is not a valid integral number, 
        or if no such sequence exists because either str is empty or it contains only whitespace characters, no conversion is performed.

        If no valid conversion could be performed, a zero value is returned. If the correct value is out of the range of representable values, 
        INT_MAX (2147483647) or INT_MIN (-2147483648) is returned.
        */

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
