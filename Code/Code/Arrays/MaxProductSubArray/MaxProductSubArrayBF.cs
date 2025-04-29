namespace Code.Arrays.MaxProductSubArray
{
    class MaxProductSubArrayBF
    {
        public static void CallMaxProductSubArrayBF()
        {
            int[] nums = { 1, 0, -5, 2, 3, -8, -9 };
            Console.WriteLine(MaxProduct(nums));
        }
        public static int MaxProduct(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            int ans = Int32.MinValue;
            for(int i = 0; i < nums.Length; i++)
            {
                int subProduct = nums[i];
                for(int j = i+1; j < nums.Length; j++)
                {
                    subProduct *= nums[j];
                    ans = Math.Max(ans, subProduct);
                }
                ans = Math.Max(ans, subProduct);
            }
            return ans;
        }
    }
}
