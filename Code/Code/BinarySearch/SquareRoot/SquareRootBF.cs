namespace Code.BinarySearch.SquareRoot
{
    class SquareRootBF
    {
        public static void SquareRootBFCall()
        {
            int x = 8;
            Console.WriteLine(SquareRoot(x));
        }
        private static int SquareRoot(int n)
        {
            for(int i=0;i < n / 2; i++)
            {
                if (i * i == n)
                {
                    return i;
                }
                else if (i * i > n)
                {
                    return i - 1;
                }
            }
            return 1;
        }
    }
}
