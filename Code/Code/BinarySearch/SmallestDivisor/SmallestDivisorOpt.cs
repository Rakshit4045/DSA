namespace Code.BinarySearch.SmallestDivisor
{
    class SmallestDivisorOpt
    {
        public static void SmallestDivisorOptCall()
        {
            int[] nums = { 1, 2, 5, 9 };
            int threshold = 6;
            Console.WriteLine(SmallestDivisor(nums, threshold));
        }
        private static int Operation(int[] nums, int div)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += (int)Math.Ceiling((double)nums[i] / div);
            }
            return sum;
        }
        private static int SmallestDivisor(int[] nums, int threshold)
        {
            int maxVal = Int32.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                maxVal = Math.Max(maxVal, nums[i]);
            }
            int low = 1, high = maxVal;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (Operation(nums, mid) <= threshold)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return low;
        }
    }
}
