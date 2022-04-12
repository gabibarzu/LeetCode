using System;

namespace LeetCode.Solutions.Design
{
    /// <summary>
    /// 348. Design Tic-Tac-Toe
    /// Url: https://leetcode.com/problems/design-tic-tac-toe/
    /// Time complexity: O(1)
    /// Space complexity: O(n)
    /// </summary>
    public class TicTacToe
    {
        private int size;
        private int[] rows;
        private int[] columns;
        private int diagonal;
        private int antiDiagonal;

        public TicTacToe(int n)
        {
            size = n;
            rows = new int[n];
            columns = new int[n];
        }

        public int Move(int row, int col, int player)
        {
            var playerValue = player == 1 ? 1 : -1;
            rows[row] += playerValue;
            columns[col] += playerValue;
            if (row == col)
            {
                diagonal += playerValue;
            }

            if (row == rows.Length - col - 1)
            {
                antiDiagonal += playerValue;
            }

            if (Math.Abs(rows[row]) == size
                || Math.Abs(columns[col]) == size
                || Math.Abs(diagonal) == size
                || Math.Abs(antiDiagonal) == size)
            {
                return player;
            }

            return 0;
        }
    }
}