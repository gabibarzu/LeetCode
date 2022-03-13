namespace LeetCode.Solutions.ArraysAndStrings
{
    public static class StrStr
    {
        /// <summary>
        /// Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public static int Solution(string haystack, string needle)
        {
            var haystackLength = haystack.Length;
            var needleLength = needle.Length;

            if (haystackLength == 0 && needleLength == 0)
            {
                return 0;
            }
            if (haystackLength != 0 && needleLength == 0)
            {
                return 0;
            }
            if (haystackLength < needleLength)
            {
                return -1;
            }

            for (var haystackIndex = 0; haystackIndex <= haystackLength - needleLength; haystackIndex++)
            {
                int needleIndex;
                for (needleIndex = 0; needleIndex < needleLength; needleIndex++)
                {
                    if (haystack[haystackIndex + needleIndex] != needle[needleIndex])
                    {
                        break;
                    }
                }

                if (needleIndex == needleLength)
                {
                    return haystackIndex;
                }
            }

            return -1;
        }
    }
}