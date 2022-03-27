namespace LeetCode.Solutions.Helpers
{
    public class InsertionSort
    {
        void Sort(int[] arr)
        {
            var n = arr.Length;
            for (var i = 1; i < n; ++i)
            {
                var key = arr[i];
                var j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j -= 1;
                }
                arr[j + 1] = key;
            }
        }
    }
}