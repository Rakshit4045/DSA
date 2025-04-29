namespace Code.BinarySearch.SingleElementInArray
{
    class SingleElementInArrayBF
    {
        public static void SingleElementInArrayBFCall()
        {
            int[] nums = { 3, 3, 7, 7, 10, 11, 11 };
            Console.WriteLine(SingleElementInArray(nums));
        }
        private static int SingleElementInArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                     if (nums[i] != nums[i + 1])return nums[i];
                }
                else if (i == nums.Length - 1)
                {
                    if (nums[i] != nums[i - 1])return nums[i];
                }
                else if (nums[i] != nums[i - 1] && nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
            }
            return -1;
        }
    }
}
