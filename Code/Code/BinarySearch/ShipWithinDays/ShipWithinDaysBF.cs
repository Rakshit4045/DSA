namespace Code.BinarySearch.ShipWithinDays
{
    class ShipWithinDaysBF
    {
        public static void ShipWithinDaysBFCall()
        {
            int[] weights = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int days = 10;
            Console.WriteLine(ShipWithinDays(weights, days));
        }
        private static int Operation(int[] weights, int capacity)
        {
            int load = 0, days = 1;
            for (int i = 0; i < weights.Length; i++)    
            {
                if (load + weights[i] > capacity)
                {
                    days += 1; //move to next day
                    load = weights[i]; //load the weight.
                }
                else
                {
                    //load the weight on the same day.
                    load += weights[i];
                }
            }
            return days;
        }
        private static int ShipWithinDays(int[] weights, int days)
        {
            int sum = 0, maxVal = Int32.MinValue;
            for (int i = 0; i < weights.Length; i++)
            {
                sum = sum + weights[i];
                maxVal = Math.Max(maxVal, weights[i]);
            }
            for(int i=maxVal; i <= sum; i++)
            { 
                if (Operation(weights, i) <= days)
                {
                    return i;
                }
            }
            return maxVal;
        }
    }
}
