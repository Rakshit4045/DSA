namespace Code.BinarySearch.SingleElementInArray
{
    class SingleElementInArrayOpt2
    {
        public static void SingleInArrayOpt2Call()
        {
            int[] nums = { 0, 0, 1, 2, 2, 3, 3, 4, 4, 8, 8 };
            Console.WriteLine(SingleElementInArray(nums));
        }
        private static int SingleElementInArray(int[] nums) 
        {
            if (nums.Length == 0) return nums[0];
            else if (nums[0] != nums[1]) return nums[0];
            else if (nums[nums.Length - 2] != nums[nums.Length - 1]) return nums[nums.Length-1];

            int low = 1, high = nums.Length - 2;
            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (nums[mid] != nums[mid - 1] && nums[mid] != nums[mid + 1]) return nums[mid];

                if ((mid % 2 == 0 && nums[mid] == nums[mid + 1]) || (mid%2 != 0 && nums[mid] == nums[mid - 1]))
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }
    }
}
