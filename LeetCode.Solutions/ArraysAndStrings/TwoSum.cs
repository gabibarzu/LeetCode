using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.ArraysAndStrings
{
    public static class TwoSum
    {
        /// <summary>
        /// Time: O(n)
        /// Space: O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] Solution(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var rest = target - nums[i];
                if (dictionary.ContainsKey(rest))
                {
                    return new[] { i, dictionary[rest] };
                }

                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary.Add(nums[i], i);

                }
            }

            return null;
        }

        public static void Test()
        {
            var nums = new[] { 2, 7, 11, 15 };
            const int target = 26;
            var solution = Solution(nums, target);
            Console.WriteLine(nameof(TwoSum));
            Console.WriteLine(solution[0] + " - " + solution[1]);
            Console.WriteLine();
        }

        public static void ComplexTest()
        {
            var nums = new[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            const int target = 11;
            var solution = Solution(nums, target);
            Console.WriteLine(nameof(TwoSum));
            Console.WriteLine(solution[0] + " - " + solution[1]);
            Console.WriteLine();
        }
    }
}