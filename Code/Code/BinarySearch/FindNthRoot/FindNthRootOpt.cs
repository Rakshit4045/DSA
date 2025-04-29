namespace Code.BinarySearch.FindNthRoot
{
    class FindNthRootOpt
    {
        public static void FindNthRootOptCall()
        {
            int n = 3;
            int m = 27;
            Console.WriteLine(FindNthRoot(n, m));
        }
        private static int FindNthRoot(int n, int m)
        {
            if (n == 1) return m;

            int low = 0, high = m;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                double power = Math.Pow(mid, n);
                if (power > m)
                {
                    high = mid - 1;
                }
                else if (power < m)
                {
                    low = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}
