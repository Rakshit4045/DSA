namespace Code.Arrays.MergeSortedArrays
{
    class MergeSortedArrayBF
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
            int[] ans = new int[m + n];
            int p = 0, q = 0;
            for(int i = 0; i < m + n; i++)
            {
                if (p < m && (q >= n || nums1[p] <= nums2[q]))
                {
                    ans[i] = nums1[p];
                    p++;
                }
                else
                {
                    ans[i] = nums2[q];
                    q++;
                }
            }
            PrintMergeSortedArray(ans);
        }
        private static void PrintMergeSortedArray(int[] nums)
        {
            Console.WriteLine(String.Join(" ,", nums));
        }
    }
}
