namespace Code.BinarySearch.SearchInsertPosition
{
    class SearchInsertPositionBF
    {
        public static void SearchInsertPositionBFCall()
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 7;
            Console.WriteLine(SearchInsert(nums, target));
        }
        private static int SearchInsert(int[] nums, int target)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target || nums[i] > target) return i;
            }
            return nums.Length;
        }
    }
}
