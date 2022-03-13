using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.ArraysAndStrings
{
    public static class RomanToInteger
    {
        private static readonly Dictionary<string, int> Values = new()
        {
            {"M", 1000},
            {"D", 500},
            {"C", 100},
            {"L", 50},
            {"X", 10},
            {"V", 5},
            {"I", 1}
        };

        public static int Solution(string s)
        {
            var sum = 0;
            var i = 0;
            while (i < s.Length)
            {
                var currentSymbol = s.Substring(i, 1);
                var currentValue = Values[currentSymbol];
                var nextValue = 0;
                if (i + 1 < s.Length)
                {
                    var nextSymbol = s.Substring(i + 1, 1);
                    nextValue = Values[nextSymbol];
                }

                if (currentValue < nextValue)
                {
                    sum += (nextValue - currentValue);
                    i += 2;
                }
                else
                {
                    sum += currentValue;
                    i += 1;
                }

            }
            return sum;
        }

        public static void Test()
        {
            const string s = "XIV";
            var solution = Solution(s);
            Console.WriteLine(nameof(RomanToInteger));
            Console.WriteLine(solution);
            Console.WriteLine();
        }
    }
}