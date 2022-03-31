namespace LeetCode.Solutions.ArraysAndStrings
{
    /// <summary>
    /// 392. Is Subsequence
    /// URL: https://leetcode.com/problems/is-subsequence/
    /// Time complexity: O(t)
    /// Space complexity: O(1)
    /// </summary>
    public class IsSubsequence
    {
        public static bool IsSubsequenceSolution(string s, string t)
        {
            var sSize = s.Length;
            var tSize = t.Length;
            var i = 0;
            var j = 0;

            while (i < sSize && j < tSize)
            {
                if (s[i] == t[j])
                {
                    i++;
                }
                j++;
            }

            return i == sSize;
        }
    }
}