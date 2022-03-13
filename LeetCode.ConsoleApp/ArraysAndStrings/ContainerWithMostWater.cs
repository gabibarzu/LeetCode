
using System;

namespace LeetCode.ConsoleApp.ArraysAndStrings
{
    public static class ContainerWithMostWater
    {
        /// <summary>
        /// Time: O(n)
        /// Space: O(1)
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        private static int Solution(int[] height)
        {
            var max = 0;
            var left = 0;
            var right = height.Length - 1;
            while (left < right)
            {
                var currentArea = Math.Min(height[left], height[right]) * (right - left);
                max = Math.Max(currentArea, max);
                
                if (height[left] > height[right])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return max;
        }

        public static void Test()
        {
            var height = new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            var solution = Solution(height);
            Console.WriteLine(nameof(ContainerWithMostWater));
            Console.WriteLine(solution);
            Console.WriteLine();
        }
    }
}