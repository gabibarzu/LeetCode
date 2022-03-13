namespace LeetCode.Solutions.Others
{
    public static class ReverseInteger
    {
        public static int Reverse(int x)
        {
            if (x <= int.MinValue || x >= int.MaxValue)
            {
                return 0;
            }

            if (x == 0)
            {
                return x;
            }

            var sign = 1;
            if (x < 0)
            {
                sign = -1;
                x *= -1;
            }

            var result = 0;
            while (x > 0)
            {
                if (result >= int.MaxValue / 10)
                {
                    return 0;
                }
                result = x % 10 + result * 10;
                x /= 10;
            }

            return result * sign;
        }
    }
}