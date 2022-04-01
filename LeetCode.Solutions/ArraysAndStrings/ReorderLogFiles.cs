using System;

namespace LeetCode.Solutions.ArraysAndStrings
{
    /// <summary>
    /// 937. Reorder Data in Log Files
    /// URL: https://leetcode.com/problems/reorder-data-in-log-files/
    /// Time complexity: O(M * N * log N)
    /// Space complexity: O(M * log N)
    /// </summary>
    public class ReorderLogFiles
    {
        public static string[] ReorderLogFilesSolution(string[] logs)
        {
            Array.Sort(logs, (log1, log2) =>
            {
                var index1 = log1.IndexOf(' ');
                var id1 = log1.Substring(0, index1);
                var main1 = log1.Substring(index1 + 1);

                var index2 = log2.IndexOf(' ');
                var id2 = log2.Substring(0, index2);
                var main2 = log2.Substring(index2 + 1);

                var isDigit1 = char.IsDigit(main1[0]);
                var isDigit2 = char.IsDigit(main2[0]);

                if (!isDigit1 && !isDigit2)
                {
                    var value = main1.CompareTo(main2);
                    return value == 0 ? id1.CompareTo(id2) : value;
                }

                return isDigit1 ? isDigit2 ? 0 : 1 : -1;
            });
            return logs;
        }
    }
}