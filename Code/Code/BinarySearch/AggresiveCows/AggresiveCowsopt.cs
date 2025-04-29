namespace Code.BinarySearch.AggresiveCows
{
    class AggresiveCowsopt
    {
        public static void AggresiveCowsOptCall()
        {
            int[] arr = { 4, 2, 1, 3, 6 };
            int k = 2;
            Console.WriteLine(AggresiveCows(arr, k));
        }
        private static bool Operation(int[] arr, int dist, int cows)
        {
            int last = arr[0], cnt = 1;
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] - last >= dist)
                {
                    cnt++;
                    last = arr[i];
                }
                if (cnt == cows) return true;
            }
            return false;
        }
        private static int AggresiveCows(int[] arr, int k)
        {
            Array.Sort(arr);
            int n = arr.Length, maxVal = arr[n - 1], minVal = arr[0];
            int low = 0, high = maxVal - minVal;
            while(low <= high)
            {
                int mid = (low + high) / 2;
                if(Operation(arr, mid, k))
                {
                    low = mid + 1;
                }else
                {
                    high = mid - 1;
                }
            }
            return high;
        }
    }
}
