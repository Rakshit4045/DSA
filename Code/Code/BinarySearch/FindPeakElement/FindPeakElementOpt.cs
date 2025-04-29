namespace Code.BinarySearch.FindPeakElement
{
    class FindPeakElementOpt
    {
        public static void FindPeakElementOptCall()
        {
            int[] nums = { 1, 2, 3, 5, 6, 4 };
            Console.WriteLine(FindPeakElement(nums));
        }
        private static int FindPeakElement(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] > nums[mid + 1])
                {
                    right = mid; // Move to the left half
                }
                else
                {
                    left = mid + 1; // Move to the right half
                }
            }
            return left; // or right, both are the same at this point
        }
    }
}
