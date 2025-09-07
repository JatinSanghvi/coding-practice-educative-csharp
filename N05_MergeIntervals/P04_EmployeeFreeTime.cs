// Employee Free Time
// ==================
//
// You're given a list containing the schedules of multiple employees. Each person's schedule is a list of
// non-overlapping intervals in sorted order. An interval is specified with the start and end time, both being positive
// integers. Your task is to find the list of finite intervals representing the free time for all the employees.
//
// > Note: The common free intervals are calculated between the earliest start time and the latest end time of all
// meetings across all employees.
//
// Constraints:
//
// - 1 ≤ schedule.length, schedule[i].length ≤ 50
// - 0 ≤ interval.start < interval.end ≤ 10^8, where `interval` is any interval in the list of schedules.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N05_MergeIntervals.P04_EmployeeFreeTime;

public class Solution
{
    // Time complexity: O(n*logn), Space complexity: O(n), where n is number of total intervals across all employees.
    public static List<Interval> EmployeeFreeTime(List<List<Interval>> schedule)
    {
        // Should have `gotFree` property instead of `gotBusy`, else free events will line up before busy events in
        // `events` and that may result in intervals with zero ranges.
        (int time, bool gotFree)[] events = schedule
            .SelectMany(intervals => intervals)
            .SelectMany(interval => new[] { (interval.start, false), (interval.end, true) })
            .Order()
            .ToArray();

        int busyCount = 0;
        int freeStartTime = int.MinValue;
        var freeIntervals = new List<Interval>();

        foreach ((int time, bool gotFree) in events)
        {
            if (gotFree)
            {
                busyCount--;
                if (busyCount == 0)
                {
                    freeStartTime = time;
                }
            }
            else
            {
                if (busyCount == 0 && freeStartTime != int.MinValue)
                {
                    freeIntervals.Add(new Interval(freeStartTime, time));
                }
                busyCount++;
            }
        }

        return freeIntervals;
    }
}

public class Interval(int start, int end)
{
    public int start = start;
    public int end = end;
}

internal static class Tests
{
    public static void Run()
    {
        Run(
            [
                [(2, 5), (12, 15)],
                [(1, 2), (10, 12)],
                [(3, 4), (13, 14)],
                [(5, 6), (15, 16)],
                [(7, 9)],
            ],
            [(6, 7), (9, 10)]);
    }

    private static void Run((int, int)[][] scheduleTuples, (int, int)[] expectedResultTuples)
    {
        List<List<Interval>> schedule = scheduleTuples
            .Select(intervals => intervals
                .Select(interval => new Interval(interval.Item1, interval.Item2))
                .ToList())
            .ToList();

        List<Interval> result = Solution.EmployeeFreeTime(schedule);
        (int, int)[] resultTuples = result.Select(interval => (interval.start, interval.end)).ToArray();
        Utilities.PrintSolution(scheduleTuples, resultTuples);
        CollectionAssert.AreEqual(expectedResultTuples, resultTuples);
    }
}
