namespace Code.Arrays.CountInversions
{
    class CountInversionOpt
    {
        public static void CallCountInversionOpt()
        {
            int[] arr = { 5, 4, 1, 3, 2 };
            Console.WriteLine("Answer = " + InversionCount(arr));
        }

        private static int Merge(int[] arr, int low, int mid, int high)
        {
            List<int> temp = new List<int>();
            int left = low, right = mid + 1;

            int cnt = 0;

            while(left <= mid && right <= high)
            {
                if (arr[left] <= arr[right])
                {
                    temp.Add(arr[left++]);
                }
                else
                {
                    cnt += (mid - left + 1);
                    temp.Add(arr[right++]);
                }
            }

            while(left <= mid)
            {
                temp.Add(arr[left++]);
            }

            while(right <= high)
            {
                temp.Add(arr[right++]);
            }

            for(int i = low; i <= high; i++)
            {
                arr[i] = temp[i - low];
            }
            return cnt;
        }

        private static int MergeSort(int[] arr, int low, int high)
        {
            int cnt = 0, mid = (low + high) / 2;
            if (low >= high) return cnt;
            cnt += MergeSort(arr, low, mid);
            cnt += MergeSort(arr, mid + 1, high);
            cnt += Merge(arr, low, mid, high);
            return cnt;
        }

        public static int InversionCount(int[] arr)
        {
            return MergeSort(arr, 0, arr.Length - 1);
        }

        private static void PrintInversionCount(int a, int b)
        {
            Console.WriteLine(a + " " + b);
        }
    }
}
