namespace Code.BinarySearch.SearchInsertPosition
{
    class SearchInsertPositionOpt
    {
        public static void SearchInsertPositionOptCall()
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 2;
            Console.WriteLine(SearchInsert(nums, target));
        }
        private static int SearchInsert(int[] nums, int target)
        {
            int front = 0, back = nums.Length-1;
            int mid = 0;
            while(front <= back)
            {
                mid = (front + back) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    front = mid + 1;
                }
                else
                {
                    back = mid - 1;
                }
            }
            return nums[mid] > target ? mid : mid + 1;
        }
    }
}
