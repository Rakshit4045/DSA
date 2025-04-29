namespace Code.BinarySearch.KthMissingNumber
{
    class KthMissingNumberBF
    {
        public static void KthMissingNumberBFCall()
        {
            int[] arr = { 1, 2, 3, 4,};
            int k = 5;
            Console.WriteLine(KthMissingNumber(arr, k));
        }
        private static int KthMissingNumber(int[] arr, int k)
        {
            int maxNum = arr[arr.Length - 1], temp = k;
            for(int i=1, j = 0; i <= maxNum+k; i++)
            {
                if (j < arr.Length && arr[j] == i)
                {
                    j++;
                }
                else
                {
                    temp--;
                    if (temp == 0)
                    {
                        return i;
                    }
                }
            }
            return -1; //if not found
        }
    }
}
