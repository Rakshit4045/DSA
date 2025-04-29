namespace Code.BinarySearch.NumberOfOccurrence
{
    class NumberOfOccurrenceOpt
    {
        public static void NumberOfOccurrenceOptCall()
        {
            int[] nums = { 1, 1, 2, 2, 2, 2, 3 };
            int target = 1;
            Console.WriteLine(NumberOfOccurrence(nums, target));
        }
        private static int NumberOfOccurrence(int[] nums, int target)
        {
            int front = 0, back = nums.Length - 1;
            int mid = 0, count = 0;
            while(front <= back)
            {
                mid = (front + back) / 2;
                if (nums[mid] < target)
                {
                    front = mid + 1;
                }else if (nums[mid] > target)
                {
                    back = mid - 1;
                }
                else
                {
                    break;
                }
            }
            if (nums[mid] == target)
            {
                int index = mid;
                while (index >= 0 && nums[index] == target)
                {
                    index--;
                    count++;
                }
                index = mid + 1;
                while(index < nums.Length && nums[index] == target)
                {
                    index++;
                    count++;
                }
            }
            return count;
        }
    }
}
