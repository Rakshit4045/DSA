namespace Code.Arrays.MergeIntervals
{
    class MergeIntervalsBF
    {
        public static void CallMergeIntervalsBF()
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

            for (int i = 0; i < n; i++)
            {
                int start = intervals[i][0];
                int end = intervals[i][1];

                if(ans.Count > 0 && end <= ans[ans.Count - 1][1])
                {
                    continue;
                }

                for(int j = i + 1; j < n; j++)
                {
                    if (intervals[j][0] <= end)
                    {
                        end = Math.Max(end, intervals[j][1]);
                    } else
                    {
                        break;
                    }
                }
                ans.Add(new List<int>{ start, end });
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
