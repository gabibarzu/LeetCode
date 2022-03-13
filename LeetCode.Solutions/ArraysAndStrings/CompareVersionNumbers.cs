using System;

namespace LeetCode.Solutions.ArraysAndStrings
{
    public static class CompareVersionNumbers
    {
        public static int Solution(string version1, string version2)
        {
            var version1Numbers = version1.Split(".");
            var version2Numbers = version2.Split(".");
            var version1NumbersLength = version1Numbers.Length;
            var version2NumbersLength = version2Numbers.Length;

            for (var i = 0; i < Math.Max(version1NumbersLength, version2NumbersLength); i++)
            {
                var version1Number = i < version1NumbersLength ? int.Parse(version1Numbers[i]) : 0;
                var version2Number = i < version2NumbersLength ? int.Parse(version2Numbers[i]) : 0;
                if (version1Number != version2Number)
                {
                    return version1Number > version2Number ? 1 : -1;
                }
            }
            return 0;
        }
    }
}