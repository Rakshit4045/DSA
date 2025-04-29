using System.Runtime.ExceptionServices;
using System.Security.Cryptography;

namespace Code.BinarySearch.BinarySearch
{
    class BinarySearchOpt
    {
        public static void BinarySearchOptCall()
        {
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            int target = 2;
            Console.WriteLine(BinarySearch(nums, target));
        }
        private static int BinarySearch(int[] nums, int target)
        {
            int front = 0, back = nums.Length - 1, mid = 0;
            while(front <= back)
            {
                mid = (front + back) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                } else if (nums[mid] < target)
                {
                    front = mid + 1;
                }
                else
                {
                    back = mid - 1;
                }
            }
            return -1;
        }
    }
}
