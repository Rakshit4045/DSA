namespace Code.BinarySearch.SquareRoot
{
    class SquareRootOpt
    {
        public static void SquareRootOptCall()
        {
            int x = 37;
            Console.WriteLine(SquareRoot(x));
        }
        private static int SquareRoot(int n)
        {
            int low = 0, high = n;
            while(low < high)
            {
                int mid = (low + high) / 2;
                if(mid * mid > n)
                {
                    high = mid - 1;
                }
                else if (mid * mid < n)
                {
                    low = mid + 1;
                }
                else
                {
                    return mid; // Perfect square
                }
            }
            return low - 1;
        }
    }
}
