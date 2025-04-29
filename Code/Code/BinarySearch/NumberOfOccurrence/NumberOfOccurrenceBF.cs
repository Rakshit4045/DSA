namespace Code.BinarySearch.NumberOfOccurrence
{
    class NumberOfOccurrenceBF
    {
        public static void NumberOfOccurrenceBFCall()
        {
            int[] nums = { 8, 9, 10, 12, 12, 12 };
            int target = 12;
            Console.WriteLine(NumberOfOccurrence(nums, target));
        }
        private static int NumberOfOccurrence(int[] nums, int target)
        {
            int count = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    while (i < nums.Length && nums[i] == target)
                    {
                        count++;
                        i++;
                    }
                    return count;
                }
            }
            return count;
        }
    }
}
