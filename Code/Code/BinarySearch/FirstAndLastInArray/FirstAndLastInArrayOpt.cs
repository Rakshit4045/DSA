namespace Code.BinarySearch.FirstAndLastInArray
{
    class FirstAndLastInArrayOpt
    {
        public static void FirstAndLastInArrayOptCall()
        {
            int[] nums = { 5, 7, 7, 8, 8, 10 };
            int target = 6;
            int[] ans = FirstAndLastInArray(nums, target);
            Console.WriteLine(ans[0] + " " + ans[1]);
        }
        private static int[] FirstAndLastInArray(int[] nums, int target)
        {
            if (nums.Length == 0) return [-1, -1];
            int front = 0, back = nums.Length - 1;
            int mid = -1;
            while(front <= back)
            {
                mid = (front + back) / 2;
                if(nums[mid] < target)
                {
                    front = mid + 1;
                } else if (nums[mid] > target)
                {
                    back = mid - 1;
                }else
                {
                    break;
                }
            }
            int[] ans = new int[2];
            if (nums[mid] == target)
            {
                int index = mid;
                while (index >= 0 && nums[index] == target)
                {
                    index--;
                }
                ans[0] = index + 1;
                index = mid;
                while(index < nums.Length && nums[index] == target)
                {
                    index++;
                }
                ans[1] = index - 1;
                return ans;
            }
            return [-1, -1];
        }
    }
}
