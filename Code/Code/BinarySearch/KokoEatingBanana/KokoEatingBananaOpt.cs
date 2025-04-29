namespace Code.BinarySearch.KokoEatingBanana
{
    class KokoEatingBananaOpt
    {
        public static void KokoEatingBananaOptCall()
        {
            int[] piles = { 332484035, 524908576, 855865114, 632922376, 222257295, 690155293, 112677673, 679580077, 337406589, 290818316, 877337160, 901728858, 679284947, 688210097, 692137887, 718203285, 629455728, 941802184 };
            int h = 823855818;
            Console.WriteLine(KokoEatingBanana(piles, h));
        }
        private static int FindMax(int[] piles)
        {
            int maxVal = Int32.MinValue;
            for(int i = 0; i < piles.Length; i++)
            {
                maxVal = Math.Max(maxVal, piles[i]);
            }
            return maxVal;
        }
        private static double CalculateHours(int[] piles, int k)
        {
            double total = 0;
            for(int i = 0; i < piles.Length; i++)
            {
                total += Math.Ceiling(piles[i] / (double)k);
            }
            return total; 
        }
        private static int KokoEatingBanana(int[] piles, int k)
        {
            int max = FindMax(piles);
            int low = 1, high = max;
            while(low <= high)
            {
                int mid = (low + high) / 2;
                if(CalculateHours(piles, mid) <= k)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return low;
        }
    }
}
