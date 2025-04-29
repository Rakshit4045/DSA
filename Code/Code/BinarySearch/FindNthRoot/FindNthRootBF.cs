namespace Code.BinarySearch.FindNthRoot
{
    class FindNthRootBF
    {
        public static void FindNthRootBFCall()
        {
            int n = 8;
            int m = 3;
            Console.WriteLine(FindNthRoot(n, m));
        }
        private static int FindNthRoot(int n, int m)
        {
            for (int i = 0; i < n / 2; i++)
            {
                if (Math.Pow(i, m) == n)
                {
                    return i;
                }
                else if (Math.Pow(i, m) > n)
                {
                    return i - 1;
                }
            }
            return 1;
        }
    }
}
