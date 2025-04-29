using System.Runtime.InteropServices.Marshalling;

namespace Code.Arrays.MaxProductSubArray
{
    class MaxProductSubArrayOpt
    {
        public static void CallMaxProductSubArrayOpt()
        {
            int[] nums = { -1, -2, -3, 0 };
            Console.WriteLine(MaxProduct(nums));
        }
        public static int MaxProduct(int[] nums)
        {
            int ans = Int32.MinValue;
            int n = nums.Length;
            int pre = 1, suff = 1;

            for(int i = 0; i < n; i++)
            {
                if (pre == 0) pre = 1;
                if (suff == 0) suff = 1;
                pre *= nums[i];
                suff *= nums[n - i - 1];
                ans = Math.Max(ans, Math.Max(pre, suff));
            }
            return ans;
        }
    }
}
