namespace Code.BinarySearch.MinimumInRotatedArray
{
    class MinimumInRotatedArrayOpt
    {
        public static void MinimumInRotatedArrayOptCall()
        {
            int[] nums = { 5, 1, 2, 3, 4 };
            Console.WriteLine(MinimumInRotatedArray(nums));
        }
        private static int MinimumInRotatedArray(int[] nums)
        {
            int low = 0, high = nums.Length - 1, ans = Int32.MaxValue;
            while(low <= high)
            {
                int mid = (low + high) / 2;
                ans = Math.Min(ans, nums[mid]);

                if (nums[low] < nums[mid] && nums[high] < nums[mid])
                {
                    if (nums[low] < nums[high])
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }else if (nums[low] > nums[mid] && nums[high] > nums[mid])
                {
                    if (nums[low] > nums[high])
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
                else if (nums[low] < nums[mid])
                {
                    high = mid - 1;
                } else
                {
                    low = mid + 1;
                }
            }
            return ans;
        }
    }
}
