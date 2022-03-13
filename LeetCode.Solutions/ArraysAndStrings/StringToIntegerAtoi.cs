namespace LeetCode.Solutions.ArraysAndStrings
{
    public static class StringToIntegerAtoi
    {
        public static int Solution(string s)
        {
            var result = 0;
            var index = 0;
            var length = s.Length;
            var sign = 1;

            while (index < length && s[index] == ' ')
            {
                index++;
            }

            if (index < length && s[index] == '+')
            {
                sign = 1;
                index++;
            }
            else if (index < length && s[index] == '-')
            {
                sign = -1;
                index++;
            }

            while (index < length && char.IsDigit(s[index]))
            {
                var digit = s[index] - '0';

                if (result > int.MaxValue / 10 || result == int.MaxValue / 10 && digit > int.MaxValue % 10)
                {
                    return sign == 1 ? int.MaxValue : int.MinValue;
                }

                result = 10 * result + digit;
                index++;
            }

            return result * sign;
        }
    }
}