namespace LeetCode.Solutions.Helpers
{
    public class MergeSort
    {
        static void Merge(int[] arr, int l, int m, int r)
        {
            // Find sizes of two
            // sub arrays to be merged
            var leftArrayLength = m - l + 1;
            var rightArrayLength = r - m;

            // Create temp arrays
            var leftArray = new int[leftArrayLength];
            var rightArray = new int[rightArrayLength];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < leftArrayLength; ++i)
            {
                leftArray[i] = arr[l + i];
            }
            for (j = 0; j < rightArrayLength; ++j)
            {
                rightArray[j] = arr[m + 1 + j];
            }

            // Merge the temp arrays

            // Initial indexes of first
            // and second sub arrays
            i = 0;
            j = 0;

            // Initial index of merged
            // sub array array
            var k = l;
            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < leftArrayLength)
            {
                arr[k] = leftArray[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < rightArrayLength)
            {
                arr[k] = rightArray[j];
                j++;
                k++;
            }
        }

        // Main function that
        // sorts arr[l..r] using
        // merge()
        void Sort(int[] arr, int l, int r)
        {
            if (l >= r) return;
            // Find the middle
            // point
            var m = l + (r - l) / 2;

            // Sort first and
            // second halves
            Sort(arr, l, m);
            Sort(arr, m + 1, r);

            // Merge the sorted halves
            Merge(arr, l, m, r);
        }
    }
}