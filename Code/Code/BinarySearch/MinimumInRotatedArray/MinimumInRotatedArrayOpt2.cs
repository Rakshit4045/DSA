namespace Code.BinarySearch.MinimumInRotatedArray
{
    class MinimumInRotatedArrayOpt2
    {
        public static void MinimumInRotatedArrayOpt2Call()
        {
            int[] nums = { 8, 7, 6, 5, 1, 2, 3, 4 };
            Console.WriteLine(MinimumInRotatedArray(nums));
        }
        public static int MinimumInRotatedArray(int[] nums)
        {
            int low = 0, high = nums.Length - 1;
            int ans = Int32.MaxValue;
            int mid = 0;
            while (low <= high)
            {
                mid = (high + low) / 2;

                if (nums[low] <= nums[high])
                {
                    ans = Math.Min(ans, nums[low]);
                    break;
                }

                if (nums[low] <= nums[mid])
                {
                    ans = Math.Min(ans, nums[low]);
                    low = mid + 1;
                }
                else
                {
                    ans = Math.Min(ans, nums[mid]);
                    high = mid - 1;
                }
            }
            return ans;
        }
    }
}
