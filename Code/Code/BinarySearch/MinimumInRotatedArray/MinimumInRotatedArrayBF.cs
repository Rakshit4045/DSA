namespace Code.BinarySearch.MinimumInRotatedArrayBF
{
    class MinimumInRotatedArrayBF
    {
        public static void MinimumInRotatedArrayBFCall()
        {
            int[] nums = { 3, 4, 5, 1, 2 };
            Console.WriteLine(MinimumInRotatedArray(nums));
        }
        private static int MinimumInRotatedArray(int[] nums)
        {
            int ans = Int32.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                ans = Math.Min(ans, nums[i]);
            }
            return ans;
        }
    }
}
