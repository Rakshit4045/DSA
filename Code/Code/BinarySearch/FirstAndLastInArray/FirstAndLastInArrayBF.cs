namespace Code.BinarySearch.FirstAndLastInArray
{
    class FirstAndLastInArrayBF
    {
        public static void FirstAndLastInArrayBFCall()
        {
            int[] nums = { 5, 7, 7, 8, 8, 10 };
            int target = 6;
            int[] ans = FirstAndLastInArray(nums, target);
            Console.WriteLine(ans[0] + " " + ans[1]);
        }
        private static int[] FirstAndLastInArray(int[] nums, int target)
        {
            int[] ans = new int[2];
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    ans[0] = i;
                    while (nums[i] == target)
                    {
                        i++;
                    }
                    ans[1] = i - 1;
                    return ans;
                }
            }
            return [-1, -1];
        }

    }
}
