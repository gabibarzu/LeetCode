using System.Collections.Generic;

namespace LeetCode.Solutions.ArraysAndStrings
{
    public static class FirstUniqueCharacterInString
    {
        public static int Solution(string s)
        {
            var count = new Dictionary<char, int>();
            var length = s.Length;

            for (var i = 0; i < length; i++)
            {
                var character = s[i];
                if (!count.ContainsKey(character))
                {
                    count.Add(character, 1);
                }
                else
                {
                    count[character] = count.GetValueOrDefault(character) + 1;
                }
            }

            for (var i = 0; i < length; i++)
            {
                if (count.GetValueOrDefault(s[i]) == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}