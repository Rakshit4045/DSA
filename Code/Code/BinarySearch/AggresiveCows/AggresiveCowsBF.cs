namespace Code.BinarySearch.AggresiveCows
{
    class AggresiveCowsBF
    {
        public static void AggresiveCowsBFCall()
        {
            int[] arr = { 0, 3, 4, 7, 10, 9 };
            int k = 3;
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
            int maxVal = arr[arr.Length - 1], minVal = arr[0];
            for(int i = 1; i <= (maxVal - minVal); i++)
            {
                if(Operation(arr, i, k))
                {
                    continue;
                }
                else
                {
                    return i - 1;
                }
            }
            return maxVal - minVal;
        }
    }
}
