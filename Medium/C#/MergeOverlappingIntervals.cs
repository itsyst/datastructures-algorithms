using System;
using System.Collections.Generic;

public class MergeOverlappingIntervals
{
    public int[][] MergeOverlappingIntervalss(int[][] intervals)
    {
        if (intervals.Length == 0)
        {
            return new int[][] { };
        }

        // Sort intervals by start time
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> mergedIntervals = new List<int[]>();
        int[] currentInterval = intervals[0];
        mergedIntervals.Add(currentInterval);

        foreach (int[] interval in intervals)
        {
            int currentEnd = currentInterval[1];
            int nextStart = interval[0];
            int nextEnd = interval[1];

            if (currentEnd >= nextStart)
            {
                currentInterval[1] = Math.Max(currentEnd, nextEnd);
            }
            else
            {
                currentInterval = interval;
                mergedIntervals.Add(currentInterval);
            }
        }

        return mergedIntervals.ToArray();
    }
}
