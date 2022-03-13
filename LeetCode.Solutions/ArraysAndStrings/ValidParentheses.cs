using System.Collections.Generic;

namespace LeetCode.Solutions.ArraysAndStrings
{
    public static class ValidParentheses
    {
        private static readonly Dictionary<string, string> Matches = new()
        {
            { ")", "(" },
            { "]", "[" },
            { "}", "{" },
        };

        public static bool Solution(string s)
        {
            var stack = new Stack<string>();

            foreach (var character in s)
            {
                var current = character.ToString();

                if (Matches.ContainsKey(current))
                {
                    var top = stack.Count == 0 ? "" : stack.Pop();
                    if (top != Matches.GetValueOrDefault(current))
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(current);
                }
            }

            return stack.Count == 0;
        }
    }
}