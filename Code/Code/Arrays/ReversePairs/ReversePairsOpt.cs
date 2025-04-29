namespace Code.Arrays.ReversePairs
{
    class ReversePairsOpt
    {
        public static void CallReversPairsOpt()
        {
            int[] nums = { 2, 4, 3, 5, 1 };
            Console.WriteLine(ReversePairs(nums));
        }

        private static void Merge(int[] nums, int low, int mid, int high)
        {
            List<int> temp = new List<int>();
            int left = low;
            int right = mid + 1;

            while(left <= mid && right <= high)
            {
                if (nums[left] <= nums[right])
                {
                    temp.Add(nums[left++]);
                }
                else
                {
                    temp.Add(nums[right++]);
                }
            }

            while (left <= mid) temp.Add(nums[left++]);

            while (right <= high) temp.Add(nums[right++]);

            for(int i = low; i <= high; i++)
            {
                nums[i] = temp[i - low];
            }
        }

        private static int CountPairs(int[] nums, int low, int mid, int high)
        {
            int right = mid + 1;
            int cnt = 0;
            for(int i=low; i <= mid; i++)
            {
                while (right <= high && nums[i] > 2 * nums[right]) right++;
                cnt += (right - (mid + 1));
            }
            return cnt;
        }

        private static int MergeSort(int[] nums, int low, int high)
        {
            int cnt = 0, mid = (low + high) / 2;
            if (low >= high) return cnt;
            cnt += MergeSort(nums, low, mid);
            cnt += MergeSort(nums, mid + 1, high);
            cnt += CountPairs(nums, low, mid, high);
            Merge(nums, low, mid, high);
            return cnt;
        }
        public static int ReversePairs(int[] nums)
        {
            return MergeSort(nums, 0, nums.Length - 1);
        }
    }
}
