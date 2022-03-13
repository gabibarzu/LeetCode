using System;
using LeetCode.Solutions.ArraysAndStrings;

namespace LeetCode.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TwoSum.Test();
            TwoSum.ComplexTest();

            LongestSubstringWithoutRepeatingCharacters.Test();
            LongestSubstringWithoutRepeatingCharacters.TestOptimized();

            ContainerWithMostWater.Test();

            IntegerToRoman.Test();

            RomanToInteger.Test();

            RotateImage.Test();
             
            Console.ReadLine();
        }
    }
}
