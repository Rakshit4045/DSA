namespace Code.BinarySearch.MinimumDaysBouquet
{
    class MinimumDaysBouquetBF
    {
        public static void MinimumDaysBouquetBFCall()
        {
            int[] bloomDay = { 7, 7, 7, 7, 12, 7, 7 };
            int m = 2;
            int k = 3;
            Console.WriteLine(MinimumDaysBouquet(bloomDay, m, k));
        }
        private static bool IsValid(int[] bloomDay, int day, int m, int k)
        {
            int cnt = 0;
            int noOfBouquet = 0;
            for(int i = 0; i < bloomDay.Length; i++)
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
            if (m * k > bloomDay.Length)
            {
                return -1;
            }
            int maxV = Int32.MinValue, minV = Int32.MaxValue;
            for (int i = 0; i < bloomDay.Length; i++)
            {
                maxV = Math.Max(maxV, bloomDay[i]);
                minV = Math.Min(minV, bloomDay[i]);
            }
            for (int i = minV; i <= maxV; i++)
            {
                if(IsValid(bloomDay, i, m, k))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
