using System.Collections.Generic;

namespace LeetCode.Solutions.ArraysAndStrings
{
    /// <summary>
    /// 76. Minimum Window Substring
    /// URL: https://leetcode.com/problems/minimum-window-substring/
    /// Time Complexity: O(S + T) where S and T represent the lengths of strings S and T
    /// pace Complexity: O(S + T)
    /// </summary>
    public class MinimumWindowSubstring
    {
        public static string MinWindow(string s, string t)
        {
            var dict = new Dictionary<char, int>();
            foreach (var c in t)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            var res = string.Empty;
            var len = s.Length + 1;
            var start = 0;
            var count = t.Length;
            for (var i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    if (dict[s[i]]-- > 0)
                    {
                        count--;
                    }
                }

                while (count == 0)
                {
                    if (len > i - start + 1)
                    {
                        len = i - start + 1;
                        res = s.Substring(start, len);
                    }

                    if (dict.ContainsKey(s[start]))
                    {
                        if (dict[s[start]]++ >= 0)
                        {
                            count++;
                        }
                    }

                    start++;
                }
            }

            return res;
        }
    }
}