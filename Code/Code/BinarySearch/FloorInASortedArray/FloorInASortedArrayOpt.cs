namespace Code.BinarySearch.FloorInASortedArray
{
    class FloorInASortedArrayOpt
    {
        public static void FloorInASortedArrayOptCall()
        {
            int[] nums = { 1, 2, 8, 10, 10, 12, 19 };
            int x = 20;
            Console.WriteLine(FloorInASortedArray(nums, x));
        }
        private static int FloorInASortedArray(int[] nums, int x)
        {
            if (nums.Length == 1) return nums[0] < x ? 0 : -1;
            int front = 0, back = nums.Length;
            int mid = -1;
            while(mid < nums.Length && front < back)
            {
                mid = (front + back) / 2;
                if (nums[mid] == x)
                {
                    break;
                } else if (nums[mid] < x)
                {
                    front = mid + 1;
                } else
                {
                    back = mid - 1;
                }
            }
            if (nums[mid] <= x)
            {
                while (mid < nums.Length && nums[mid] <= x)
                {
                    mid++;
                }
                return mid - 1;
            } else if (nums[mid] > x)
            {
                while (mid >= 0 && nums[mid] > x){
                    mid--;
                }
                return mid;
            }
            return -1;
        }
    }
}
