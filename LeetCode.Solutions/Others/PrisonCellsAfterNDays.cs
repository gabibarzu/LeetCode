using System.Collections.Generic;

namespace LeetCode.Solutions.Others
{
    public class PrisonCellsAfterNDays
    {
        private static int[] ModifyPrison(int[] cells)
        {
            var newCells = new List<int>(cells).ToArray();

            for (var i = 0; i < cells.Length; i++)
            {
                if (i - 1 < 0 || i + 1 > cells.Length - 1)
                {
                    newCells[i] = 0;
                    continue;
                }

                if (cells[i - 1] == cells[i + 1])
                {
                    newCells[i] = 1;
                }
                else
                {
                    newCells[i] = 0;
                } 
            }
            return newCells;
        }

        public static int[] PrisonAfterNDays(int[] cells, int n)
        {
            while (n > 0)
            {
                cells = ModifyPrison(cells);
                n--;
            }

            return cells;
        }
    }
}