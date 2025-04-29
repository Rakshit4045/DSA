namespace Code.BinarySearch.FloorInASortedArray
{
    class FloorInASortedArrayBF
    {
        public static void FloorInASortedArrayBFCall()
        {
            int[] nums = { 1, 2, 8, 10, 10, 12, 19 };
            int x = 11;
            Console.WriteLine(FloorInASortedArray(nums, x));
        }
        private static int FloorInASortedArray(int[] nums, int x)
        {
            if (nums.Length == 1) return nums[0] < x ? 0 : -1;
            int i = 0;
            while (i < nums.Length && nums[i] <= x)
            {
                i++;
            }
            return i == 0 ? -1 : i -  1;
        }
    }
}
