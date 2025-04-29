namespace Code.BinarySearch.SearchInRotatedArrayBF
{
    class SearchInRotatedArrayBF
    {
        public static void SearchInRotatedArrayBFCall()
        {
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            int target = 0;
            Console.WriteLine(SearchInRotatedArray(nums, target));
        }
        private static int SearchInRotatedArray(int[] nums, int target)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target) return i;
            }
            return -1;
        }
    }
}
