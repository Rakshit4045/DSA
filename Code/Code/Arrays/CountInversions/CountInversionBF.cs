namespace Code.Arrays.CountInversions
{
    class CountInversionBF
    {
        public static void CallCountInversionBF()
        {
            int[] arr = { 2, 4, 1, 3, 5 };
            Console.WriteLine("Answer = " + InversionCount(arr));
        }

        public static int InversionCount(int[] arr)
        {
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j] && i < j)
                    {
                        PrintInversionCount(arr[i], arr[j]);
                        count++;
                    }
                }
            }
            return count;
        }

        private static void PrintInversionCount(int a, int b)
        {
            Console.WriteLine(a + " " + b);
        }
    }
}
