using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Arrays.MergeSortedArrays
{
    class MergeSortedArrayOpt
    {
        public static void CallMergeSortedArrayBF()
        {
            int[] nums1 = { -1, 0, 0, 3, 3, 3, 0, 0, 0 };
            int m = 6;
            int[] nums2 = { 1, 2, 2 };
            int n = 3;
            Merge(nums1, m, nums2, n);
        }
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int nums1Back = m-1, nums2Back = n-1;
            for(int i = m + n - 1; i >= 0; i--)
            {
                if (nums1Back >= 0 &&( nums2Back < 0 || nums1[nums1Back] > nums2[nums2Back]))
                {
                    nums1[i] = nums1[nums1Back];
                    nums1Back--;
                } else
                {
                    nums1[i] = nums2[nums2Back];
                    nums2Back--;
                }
            }
            PrintMergeSortedArray(nums1);
        }
        private static void PrintMergeSortedArray(int[] nums)
        {
            Console.WriteLine(String.Join(" ,", nums));
        }
    }
}
