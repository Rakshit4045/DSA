namespace Code.BinarySearch.KthMissingNumber
{
    class KthMissingNumberOpt
    {
        public static void KthMissingNumberOptCall()
        {
            int[] arr = { 1, 2, 3, 4, };
            int k = 5;
            Console.WriteLine(KthMissingNumber(arr, k));
        }
        private static int KthMissingNumber(int[] arr, int k)
        {
            int low = 0, high = arr.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int missing = arr[mid] - (mid + 1); 
                if (missing < k)
                {
                    low = mid + 1; //move to right side
                }
                else
                {
                    high = mid - 1; //move to left side
                }
            }
            return k + high + 1;
        }
    }
}
