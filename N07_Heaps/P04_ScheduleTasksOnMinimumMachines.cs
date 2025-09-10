// Schedule Tasks on Minimum Machines
// ==================================
//
// We are given an input array, `tasks`, where `tasks[i] = [start_i, end_i]` represents the start and end times of n
// tasks. Our goal is to schedule these tasks on machines given the following criteria:
//
// 1. A machine can execute only one task at a time.
// 2. A machine can begin executing a new task immediately after completing the previous one.
// 3. An unlimited number of machines are available.
//
// Find the minimum number of machines required to complete these n tasks.
//
// Constraints:
//
// - n == `tasks.length`
// - 1 ≤ `tasks.length` ≤ 10^3
// - 0 ≤ `tasks[i].start` < `tasks[i].end` ≤ 10^4

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P04_ScheduleTasksOnMinimumMachines;

public class Solution
{
    // Time complexity: O(n*logn), Space complexity: O(n).
    public static int MinimumMachines(int[][] tasks)
    {
        var runningTasks = new PriorityQueue<int, int>();

        Array.Sort(tasks, (t1, t2) => t1[0] - t2[0]);

        foreach (int[] task in tasks)
        {
            int start = task[0];
            int end = task[1];

            if (runningTasks.Count != 0 && runningTasks.Peek() <= start)
            {
                runningTasks.Dequeue();
            }

            runningTasks.Enqueue(end, end);
        }

        return runningTasks.Count;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 2], [2, 3], [4, 5], [4, 5]], 2);
        Run([[1, 4], [2, 5], [4, 7], [4, 7]], 3);
    }

    private static void Run(int[][] tasks, int expectedResult)
    {
        int result = Solution.MinimumMachines(tasks);
        Utilities.PrintSolution(tasks, result);
        Assert.AreEqual(expectedResult, result);
    }
}
