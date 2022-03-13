using System;

namespace LeetCode.Solutions.ArraysAndStrings
{
    public static class IntegerToRoman
    {
        private static readonly string[] Thousands = { "", "M", "MM", "MMM" };
        private static readonly string[] Hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        private static readonly string[] Tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        private static readonly string[] Ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        public static string Solution(int num)
        {
            return Thousands[num / 1000] + Hundreds[num % 1000 / 100] + Tens[num % 100 / 10] + Ones[num % 10];
        }

        public static void Test()
        {
            var num = 3;
            var solution = Solution(num);
            Console.WriteLine(nameof(IntegerToRoman));
            Console.WriteLine(solution);
            Console.WriteLine();
        }
    }
}