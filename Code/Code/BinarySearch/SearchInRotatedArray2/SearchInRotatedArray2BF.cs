namespace Code.BinarySearch.SearchInRotatedArray2
{
    class SearchInRotatedArray2BF
    {
        public static void SearchInRotatedArray2BFCall()
        {
            int[] nums = { 2, 5, 6, 0, 0, 1, 2 };
            int target = 0;
            Console.WriteLine(SearchInRotatedArray2(nums, target));
        }
        private static bool SearchInRotatedArray2(int[] nums, int target)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target) return true;
            }
            return false;
        }
    }
}
