namespace Code.Arrays.MergeIntervals
{
    class MergeIntervalsOpt
    {
        public static void CallMergeIntervalsOpt()
        {
            int[][] intervals = new int[][] { [1, 3], [2, 6], [8, 10], [15, 18] };
            var ans = Merge(intervals);
            PrintMergeIntervals(ans);
        }
        public static int[][] Merge(int[][] intervals)
        {
            int n = intervals.Length;
            Array.Sort(intervals, (a, b) => { return a[0] - b[0]; });

            List<List<int>> ans = new List<List<int>>();
            for(int i = 0; i < n; i++)
            {
                if(ans.Count < 1 || intervals[i][0] >= ans[ans.Count - 1][1])
                {
                    ans.Add(new List<int>{ intervals[i][0], intervals[i][1] });
                } else
                {
                    ans[ans.Count - 1][1] = Math.Max(ans[ans.Count - 1][1], intervals[i][1]);
                }
            }
            int[][] res = new int[ans.Count][];
            for(int i = 0; i < ans.Count; i++)
            {
                res[i] = new int[2] { ans[i][0], ans[i][1] };
            }
            return res;
        }

        public static void PrintMergeIntervals(int[][] ans)
        {
            for (int i = 0; i < ans.Length; i++)
            {
                for (int j = 0; j < ans[i].Length; j++)
                {
                    Console.Write(ans[i][j] + " ");
                }
            }
        }
    }
}
