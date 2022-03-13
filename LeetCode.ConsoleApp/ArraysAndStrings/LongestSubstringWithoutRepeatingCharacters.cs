using System;

namespace LeetCode.ConsoleApp.ArraysAndStrings
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        /// <summary>
        /// Sliding window optimized
        /// Time: O(n)
        /// Space: O(m)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static int Solution(string s)
        {
            var chars = new int[128];
            var left = 0;
            var right = 0;

            var res = 0;
            while (right < s.Length)
            {
                var rightCharAscii = s[right];
                chars[rightCharAscii]++;

                // Check if it appears twice
                while (chars[rightCharAscii] > 1)
                {
                    var leftCharAscii = s[left];
                    chars[leftCharAscii]--;
                    left++;
                }

                res = Math.Max(res, right - left + 1);

                right++;
            }

            return res;
        }

        /// <summary>
        /// This use indexes instead of occurrence in array
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static int SolutionOptimized(string s)
        {
            var chars = new int?[128];
            var left = 0;
            var right = 0;

            var res = 0;
            while (right < s.Length)
            {
                var rightCharAscii = s[right];

                var index = chars[rightCharAscii];

                if (index >= left && index < right)
                {
                    left = (int)(index + 1);
                }

                res = Math.Max(res, right - left + 1);

                chars[rightCharAscii] = right;
                right++;
            }

            return res;
        }

        public static void Test()
        {
            var s = "abcabcbb";
            var solution = Solution(s);
            Console.WriteLine(nameof(LongestSubstringWithoutRepeatingCharacters));
            Console.WriteLine(solution);
            Console.WriteLine();
        }

        public static void TestOptimized()
        {
            var s = "abccbcbb";
            var solution = SolutionOptimized(s);
            Console.WriteLine(nameof(LongestSubstringWithoutRepeatingCharacters));
            Console.WriteLine(solution);
            Console.WriteLine();
        }
    }
}