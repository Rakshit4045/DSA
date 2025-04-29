namespace Code.BinarySearch.SmallestDivisor
{
    class SmallestDivisorBF
    {
        public static void SmallestDivisorBFCall()
        {
            int[] nums = { 44, 22, 33, 11, 1 };
            int threshold = 5;
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
            int ans = 1;
            for (int i = 1; i <= maxVal; i++)
            {
                if (Operation(nums, i) <= threshold)
                {
                    return i;
                }
            }
            return maxVal;
        }
    }
}
