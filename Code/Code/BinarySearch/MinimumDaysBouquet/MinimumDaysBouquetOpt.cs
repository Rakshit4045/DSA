namespace Code.BinarySearch.MinimumDaysBouquet
{
    class MinimumDaysBouquetOpt
    {
        public static void MinimumDaysBouquetOptCall()
        {
            int[] bloomDay = { 1, 10, 3, 10, 2 };
            int m = 3;
            int k = 2;
            Console.WriteLine(MinimumDaysBouquet(bloomDay, m, k));
        }
        private static bool IsPossible(int[] bloomDay, int day, int m, int k)
        {
            int cnt = 0, noOfBouquet = 0;
            for (int i = 0; i < bloomDay.Length; i++)
            {
                if (bloomDay[i] <= day)
                {
                    cnt++;
                }
                else
                {
                    noOfBouquet += cnt / k;
                    cnt = 0;
                }
            }
            noOfBouquet += cnt / k;
            return noOfBouquet >= m;
        }
        private static int MinimumDaysBouquet(int[] bloomDay, int m, int k)
        {
            if((long)m * (long)k > bloomDay.Length)
            {
                return -1;
            }
            int maxDay = Int32.MinValue, minDay = Int32.MaxValue;
            for(int i=0;i < bloomDay.Length; i++)
            {
                maxDay = Math.Max(maxDay, bloomDay[i]);
                minDay = Math.Min(minDay, bloomDay[i]);
            }
            int low = minDay, high = maxDay;
            while(low <= high)
            {
                int mid = (low + high) / 2;
                if (IsPossible(bloomDay, mid, m, k))
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
