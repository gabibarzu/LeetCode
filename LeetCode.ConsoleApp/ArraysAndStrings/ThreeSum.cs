using System;
using System.Collections.Generic;

namespace LeetCode.ConsoleApp.ArraysAndStrings
{
    public static class ThreeSum
    {
        public static IList<IList<int>> Solution(int[] nums)
        {
            return null;
        }

        public static void Test()
        {
            var nums = new[] { -1, 0, 1, 2, -1, -4 };
            var solution = Solution(nums);
            Console.WriteLine(nameof(TwoSum));
            Console.WriteLine(solution[0] + " - " + solution[1]);
            Console.WriteLine();
        }
    }
}
