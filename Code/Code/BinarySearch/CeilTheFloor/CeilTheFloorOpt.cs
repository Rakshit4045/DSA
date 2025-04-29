namespace Code.BinarySearch.CeilTheFloor
{
    class CeilTheFloorOpt
    {
        public static void CeilTheFloorOptCall()
        {
            int[] nums = { 3, 4, 7, 8, 8, 10 };
            int x = 11;
            int[] ans = CeilTheFloor(nums, x);
            Console.WriteLine(ans[0] + " " + ans[1]);
        }
        private static int[] CeilTheFloor(int[] nums, int x)
        {
            int front = 0, back = nums.Length - 1;
            int mid = 0;
            while(front < back)
            {
                mid = (front + back) / 2;
                if (nums[mid] == x)
                {
                    return [nums[mid], nums[mid]];
                }else if (nums[mid] < x)
                {
                    front = mid + 1;
                } else
                {
                    back = mid - 1;
                }
            }
            if (nums[mid] > x)
            {
                while(mid >= 0 && nums[mid] > x){
                    mid--;
                }
                return [mid < 0 ? -1 : nums[mid], nums[mid + 1]];
            }
            if (nums[mid] < x)
            {
                while (mid < nums.Length && nums[mid] < x) mid++;
                return [nums[mid - 1], mid >= nums.Length ? -1 : nums[mid]];
            }
            return [-1, -1];
        }
    }
}
