namespace Code.Arrays.ReversePairs
{
    class ReversePairsBF
    {
        public static void CallReversPairsBF()
        {
            int[] nums = { 2, 4, 3, 5, 1 };
            Console.WriteLine(ReversePairs(nums));
        }
        public static int ReversePairs(int[] nums)
        {
            int cnt = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if ((long)nums[i] > (long)2 * nums[j])
                    {
                        cnt++;
                    }
                }
            }
            return cnt;
        }
    }
}
