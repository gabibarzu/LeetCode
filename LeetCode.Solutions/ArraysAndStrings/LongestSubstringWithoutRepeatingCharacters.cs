using System;

namespace LeetCode.Solutions.ArraysAndStrings
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        /// <summary>
        /// 3. Longest Substring Without Repeating Characters
        /// URL: https://leetcode.com/problems/longest-substring-without-repeating-characters
        /// Sliding window optimized
        /// Time: O(n)
        /// Space: O(m)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLongestSubstring(string s)
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
        public static int LengthOfLongestSubstringOptimized(string s)
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
    }
}