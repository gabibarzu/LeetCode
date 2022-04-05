using System.Collections.Generic;

namespace LeetCode.Solutions.DynamicProgramming
{
    /// <summary>
    /// 139. Word Break
    /// Url: https://leetcode.com/problems/word-break/
    /// </summary>
    public class WordBreak
    {
        /// <summary>
        /// Recursive with memoization
        /// Time complexity : O(n^3)
        /// Space complexity : O(n)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="wordDict"></param>
        /// <returns></returns>
        private static readonly Dictionary<string, bool> Cache = new();

        public static bool WordBreakRecursive(string s, IList<string> wordDict)
        {
            if (wordDict.Contains(s))
            {
                return true;
            }
            if (Cache.ContainsKey(s))
            {
                return Cache[s];
            }
            for (var i = 1; i < s.Length; i++)
            {
                var left = s.Substring(0, i);
                if (wordDict.Contains(left) && WordBreakRecursive(s.Substring(i), wordDict))
                {
                    Cache.Add(s, true);
                    return true;
                }
            }
            Cache.Add(s, false);
            return false;
        }

        /// <summary>
        /// Dynamic Programming
        /// Time complexity : O(n^3)
        /// Space complexity : O(n)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="wordDict"></param>
        /// <returns></returns>
        public static bool WordBreakDynamicProgramming(string s, IList<string> wordDict)
        {
            var wordDictSet = new SortedSet<string>(wordDict);
            var dp = new bool[s.Length + 1];
            dp[0] = true;
            for (var i = 1; i <= s.Length; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    if (dp[j] && wordDictSet.Contains(s.Substring(j, i)))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }
            return dp[s.Length];
        }
    }
}
