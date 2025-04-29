namespace Code.BinarySearch.FindPeakElement
{
    class FindPeakElementBF
    {
        public static void FindPeakElementBFCall()
        {
            int[] nums = { 1, 2, 3, 1 };
            Console.WriteLine(FindPeakElement(nums));
        }
        private static int FindPeakElement(int[] nums)
        {
            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1]) 
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
