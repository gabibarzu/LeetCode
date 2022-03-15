namespace LeetCode.Solutions.Helpers
{
    public class QuickSort
    {
        public static int Partition(int[] array, int low, int high)
        {
            //1. Select a pivot point.
            var pivot = array[high];

            var lowIndex = low - 1;

            //2. Reorder the collection.
            for (var j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    lowIndex++;
                    (array[lowIndex], array[j]) = (array[j], array[lowIndex]);
                }
            }

            (array[lowIndex + 1], array[high]) = (array[high], array[lowIndex + 1]);

            return lowIndex + 1;
        }

        public static void Sort(int[] array, int low, int high)
        {
            if (low >= high)
            {
                return;
            }

            var partitionIndex = Partition(array, low, high);

            //3. Recursively continue sorting the array
            Sort(array, low, partitionIndex - 1);
            Sort(array, partitionIndex + 1, high);
        }
    }
}



