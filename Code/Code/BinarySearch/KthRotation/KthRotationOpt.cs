namespace Code.BinarySearch.KthRotation
{
    class KthRotationOpt
    {
        public static void KthRotationOptCall()
        {
            int[] nums = { 39, 6, 11, 14, 18, 36, 37, 38 };
            Console.WriteLine(KthRotation(nums));
        }
        public static int KthRotation(int[] nums)
        {
            int low = 0, high = nums.Length - 1;
            int ans = Int32.MaxValue, index = 0;
            while(low <= high)
            {
                int mid = (low + high) / 2;

                if(nums[low] <= nums[high])
                {
                    if (nums[low] < ans)
                    {
                        index = low;
                        ans = nums[low];
                    }
                    break;
                }

                if (nums[low] <= nums[mid])
                {
                    if (nums[low] < ans)
                    {
                        index = low;
                        ans = nums[low];
                    }
                    low = mid + 1;
                }
                else
                {
                    if (nums[mid] < ans)
                    {
                        index = mid;
                        ans = nums[mid];
                    }
                    high = mid - 1;
                }
            }
            return index;
        }
    }
}
