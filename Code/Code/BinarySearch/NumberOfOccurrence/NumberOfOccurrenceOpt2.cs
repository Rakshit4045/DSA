namespace Code.BinarySearch.NumberOfOccurrence
{
    class NumberOfOccurrenceOpt2
    {
        public static void NumberOfOccurrenceOpt2Call()
        {
            int[] nums = { 1, 1, 2, 2, 2, 2, 3 };
            int target = 2;
            Console.WriteLine(NumberOfOccurrence(nums, target));
        }
        private static int FirstOccurrence(int[] nums, int n, int target)
        {
            int low = 0, high = n - 1;
            int first = -1;
            while(low <= high)
            {
                int mid = (low + high) / 2;
                if (nums[mid] < target)
                {
                    low = mid + 1;
                }else if (nums[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    first = mid;
                    high = mid - 1;
                }
            }
            return first;

        }
        private static int LastOccurrence(int[] nums, int n, int target)
        {
            int low = 0, high = n - 1;
            int last = -1;
            while(low <= high)
            {
                int mid = (low + high) / 2;
                if (nums[mid] < target)
                {
                    low = mid + 1;
                }else if (nums[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    last = mid;
                    low = mid + 1;
                }
            }
            return last;
        }
        private static int NumberOfOccurrence(int[] nums, int target)
        {
            int n = nums.Length;
            int first = FirstOccurrence(nums, n, target);
            if (first == -1) return 0;
            int last = LastOccurrence(nums, n, target);
            return last - first + 1;
        }
    }
}
