namespace Code.BinarySearch.BinarySearch
{
    class BinarySearchBF
    {
        public static void BinarySearchCall()
        {
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            int target = 9;
            Console.WriteLine(BinarySearch(nums, target));
        }
        private static int BinarySearch(int[] nums, int target)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target) return i;
            }
            return -1;
        }
    }
}
