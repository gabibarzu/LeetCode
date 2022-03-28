using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LeetCode.Solutions.ArraysAndStrings
{
    /// <summary>
    /// 819. Most Common Word
    /// URL: https://leetcode.com/problems/most-common-word/
    /// Time: O(n+m)
    /// Space: O(n+m)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public class MostCommonWord
    {
        public static string MostCommonWordSolution(string paragraph, string[] banned)
        {
            var regex = new Regex("[^a-zA-Z0-9 ]");
            var normalizedStr = regex.Replace(paragraph, " ").ToLower();

            var words = normalizedStr.Split(" ");
            var wordDict = new Dictionary<string, int>();

            var bannedWords = new List<string>(banned);

            foreach (var word in words)
            {
                if (bannedWords.Contains(word) || string.IsNullOrWhiteSpace(word))
                {
                    continue;
                }

                if (wordDict.ContainsKey(word))
                {
                    var value = wordDict.GetValueOrDefault(word);
                    wordDict[word] = value + 1;
                }
                else
                {
                    wordDict.Add(word, 1);
                }
            }

            var wordValue = 0;
            var wordResult = string.Empty;
            foreach (var word in words)
            {
                if (bannedWords.Contains(word) || string.IsNullOrWhiteSpace(word) || wordDict[word] <= wordValue)
                {
                    continue;
                }
                wordValue = wordDict[word];
                wordResult = word;
            }

            return wordResult;
        }
    }
}