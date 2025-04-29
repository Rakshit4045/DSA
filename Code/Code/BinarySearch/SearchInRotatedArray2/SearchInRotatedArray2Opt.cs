namespace Code.BinarySearch.SearchInRotatedArray2
{
    class SearchInRotatedArray2Opt
    {
        public static void SearchInRotatedArray2OptCall()
        {
            int[] nums = { 1, 0, 1, 1, 1 };
            int target = 0;
            Console.WriteLine(SearchInRotatedArray2(nums, target));
        }
        private static bool SearchInRotatedArray2(int[] nums, int target)
        {
            int low = 0, high = nums.Length - 1;
            while(low <= high)
            {
                int mid = (low + high) / 2;
                if (nums[mid] == target) return true;
                if (nums[low] == nums[high])
                {
                    low++;
                    high--;
                }
                if (nums[low] <= nums[mid])
                {
                    if (nums[low] <= target && target <= nums[mid])
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }else
                {
                    if (nums[mid] <= target && target <= nums[high])
                    {
                        low = mid + 1;
                    } else
                    {
                        high = mid - 1;
                    }
                }
            }
            return false;
        }
    }
}
