using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Solutions.ArraysAndStrings
{
    public static class GroupAnagrams
    {
        /// <summary>
        /// Time: O(n)
        /// Space: O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static IList<IList<string>> Solution(string[] strs)
        {
            if (!strs.Any())
            {
                return new List<IList<string>>();
            }

            var ans = new Dictionary<string, List<string>>();
            var count = new int[26];
            foreach (var s in strs)
            {
                foreach (var c in s)
                {
                    count[c - 'a']++;
                }

                var sb = new StringBuilder("");
                for (var i = 0; i < 26; i++)
                {
                    sb.Append('#');
                    sb.Append(count[i]);
                }
                var key = sb.ToString();
                if (!ans.ContainsKey(key))
                {
                    ans.Add(key, new List<string>());
                }
                ans[key].Add(s);
            }

            return new List<IList<string>>(ans.Values.ToList());
        }

        public static void Test()
        {
            var strs = new[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var solution = Solution(strs);
            Console.WriteLine(nameof(GroupAnagrams));
            Console.WriteLine(solution);
            Console.WriteLine();
        }
    }
}