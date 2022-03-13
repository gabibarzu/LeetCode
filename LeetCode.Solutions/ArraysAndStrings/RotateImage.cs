using System;

namespace LeetCode.Solutions.ArraysAndStrings
{
    public static class RotateImage
    {
        /// <summary>
        /// Time: O(m)
        /// </summary>
        /// <param name="matrix"></param>
        public static void Solution(int[][] matrix)
        {
            Transpose(matrix);
            Reflect(matrix);
        }

        public static void Transpose(int[][] matrix)
        {
            var n = matrix.Length;
            for (var i = 0; i < n; i++)
            {
                for (var j = i + 1; j < n; j++)
                {
                    (matrix[j][i], matrix[i][j]) = (matrix[i][j], matrix[j][i]);
                }
            }
        }

        public static void Reflect(int[][] matrix)
        {
            var n = matrix.Length;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n / 2; j++)
                {
                    (matrix[i][j], matrix[i][n - j - 1]) = (matrix[i][n - j - 1], matrix[i][j]);
                }
            }
        }

        public static void Test()
        {
            var matrix = new[]
            {
                new[] {1, 2, 3},
                new[] {4, 5, 6},
                new[] {7, 8, 9}};
            Console.WriteLine(nameof(RotateImage));
            Solution(matrix);
            foreach (var line in matrix)
            {
                foreach (var i in line)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}