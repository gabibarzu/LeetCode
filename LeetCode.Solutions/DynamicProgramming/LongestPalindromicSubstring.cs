using System;

namespace LeetCode.Solutions.DynamicProgramming
{
    /// <summary>
    /// 5. Longest Palindromic Substring
    /// Url: https://leetcode.com/problems/longest-palindromic-substring/
    /// Time complexity: O(n^2)
    /// Space complexity: O(1)
    /// </summary>
    public class LongestPalindromicSubstring
    {
        public static string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            int start = 0, end = 0;
            for (var i = 0; i < s.Length; i++)
            {
                var len1 = ExpandAroundCenter(s, i, i);
                var len2 = ExpandAroundCenter(s, i, i + 1);
                var len = Math.Max(len1, len2);
                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }
            return s.Substring(start, end + 1);
        }

        private static int ExpandAroundCenter(string s, int left, int right)
        {
            int L = left, R = right;
            while (L >= 0 && R < s.Length && s[L] == s[R])
            {
                L--;
                R++;
            }
            return R - L - 1;
        }
    }
}