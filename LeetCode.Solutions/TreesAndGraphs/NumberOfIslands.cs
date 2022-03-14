using System.Collections.Generic;

namespace LeetCode.Solutions.TreesAndGraphs
{
    /// <summary>
    /// 200. Number of Islands
    /// URL: https://leetcode.com/problems/number-of-islands/
    /// Time: O(M * N), m – rows and n – nr of columns
    /// Space: O(M * N)
    /// </summary>
    public static class NumberOfIslands
    {
        public static int NumIslands(char[][] grid)
        {
            var nrOfIslands = 0;
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] != '1') continue;
                    nrOfIslands++;
                    ChangeBorders(grid, i, j);
                }
            }

            return nrOfIslands;
        }

        private static void ChangeBorders(IReadOnlyList<char[]> grid, int i, int j)
        {
            if (i < 0 || i >= grid.Count || j < 0 || j >= grid[i].Length || grid[i][j] == '0')
            {
                return;
            }

            grid[i][j] = '0';
            ChangeBorders(grid, i - 1, j); // upper border
            ChangeBorders(grid, i + 1, j); // bottom border
            ChangeBorders(grid, i, j - 1); // left border
            ChangeBorders(grid, i, j + 1); // right border
        }
    }
}
