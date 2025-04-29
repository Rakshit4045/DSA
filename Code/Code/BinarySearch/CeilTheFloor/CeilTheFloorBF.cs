namespace Code.BinarySearch.CeilTheFloor
{
    class CeilTheFloorBF
    {
        public static void CeilTheFloorBFCall()
        {
            int[] nums = { 5, 6, 8, 9, 6, 5, 5, 6 };
            int x = 0;
            int[] ans = CeilTheFloor(nums, x);
            Console.WriteLine(ans[0] + " " + ans[1]);
        }
        private static int[] CeilTheFloor(int[] nums, int x)
        {
            int mn = Int32.MinValue, mx = Int32.MaxValue;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < x)
                {
                    mn = Math.Max(mn, nums[i]);
                }else if (nums[i] > x)
                {
                    mx = Math.Min(mx, nums[i]);
                }
            }
            if (mn == Int32.MinValue) mn = -1;
            if (mx == Int32.MaxValue) mx = -1;
            return [mn, mx];
        }
    }
}
