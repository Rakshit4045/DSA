namespace Code.BinarySearch.KthRotation
{
    class KthRotationBF
    {
        public static void KthRotationBFCall()
        {
            int[] nums = { 1, 2, 3, 4 };
            Console.WriteLine(KthRotation(nums));
        }
        private static int KthRotation(int[] nums)
        {
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] > nums[i]) return i;
            }
            return 0;
        }
    }
}
