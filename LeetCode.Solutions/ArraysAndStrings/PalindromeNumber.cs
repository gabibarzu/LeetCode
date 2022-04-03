namespace LeetCode.Solutions.ArraysAndStrings
{
    /// <summary>
    /// 9. Palindrome Number
    /// Url: https://leetcode.com/problems/palindrome-number/
    /// Time complexity: O(log 10 n)
    /// Space complexity: O(1)
    /// </summary>
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || x % 10 == 0 && x != 0)
            {
                return false;
            }

            var revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            return x == revertedNumber || x == revertedNumber / 10;
        }        
        
        public bool IsPalindrome_2(int x)
        {
            var tempValue = x;
            var reverse = 0;
            while (tempValue > 0)
            {
                reverse = reverse * 10 + tempValue % 10;
                tempValue /= 10;
            }

            return reverse == x;
        }
    }
}