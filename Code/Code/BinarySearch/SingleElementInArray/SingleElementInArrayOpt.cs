namespace Code.BinarySearch.SingleElementInArray
{
    class SingleElementInArrayOpt
    {
        public static void SingleElementArrayInOptCall()
        {
            int[] nums = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 8, 8 };
            Console.WriteLine(SingleElementInArray(nums));
        }
        private static int SingleElementInArray(int[] nums)
        {
            int low = 0, high = nums.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if(mid % 2 == 0)
                {
                    if (mid + 1 < nums.Length && nums[mid] == nums[mid + 1])
                    {
                        low = mid + 2;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }else
                {
                    if(mid - 1 >= 0 && nums[mid] == nums[mid - 1])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }
            return nums[low];
        }
    }
}
