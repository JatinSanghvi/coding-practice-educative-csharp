// Find Right Interval
// ===================
//
// You are given an array of `intervals` where each interval is represented by a pair [start_i, end_i]. The start_i
// values are unique, meaning no two intervals begin at the same time.
//
// The task is to find the right interval for each interval in the list. The right interval for an interval i is an
// interval j such that start_j ≥ end_i and start_j is minimized (i.e., it is the smallest start time among all valid
// intervals that is greater than or equal to end_i). Note that i may equal j.
//
// Return an array of right interval indexes for each interval i. If no right interval exists for interval i, then put -1
// at index i.
//
// Constraints:
//
// - 1 ≤ `intervals.length` ≤ 1000
// - `intervals[i].length` == 2
// - -10^6 ≤ start_i ≤ end_i ≤ 10^6
// - The start times are guaranteed to be unique.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P07_FindRightInterval;

public class Solution
{
    // Time complexity: O(n*logn), Space complexity: O(n).
    public static int[] FindRightInterval(int[][] intervals)
    {
        // Since, it's a heap problem, solving it using heap data structure.
        var startQueue = new PriorityQueue<(int time, int index), int>();
        var endQueue = new PriorityQueue<(int time, int index), int>();

        for (int i = 0; i < intervals.Length; i++)
        {
            startQueue.Enqueue((intervals[i][0], i), intervals[i][0]);
            endQueue.Enqueue((intervals[i][1], i), intervals[i][1]);
        }

        var rightInterval = new int[intervals.Length];

        while (endQueue.Count != 0)
        {
            (int endTime, int endIndex) = endQueue.Dequeue();
            while (startQueue.Count != 0 && startQueue.Peek().time < endTime)
            {
                startQueue.Dequeue();
            }

            rightInterval[endIndex] = startQueue.Count != 0 ? startQueue.Peek().index : -1;
        }

        return rightInterval;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[3, 4], [2, 3], [1, 3]], [-1, 0, 0]);
    }

    private static void Run(int[][] intervals, int[] expectedResult)
    {
        int[] result = Solution.FindRightInterval(intervals);
        Utilities.PrintSolution(intervals, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
