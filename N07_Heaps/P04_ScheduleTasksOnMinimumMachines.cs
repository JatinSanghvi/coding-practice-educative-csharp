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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P04_ScheduleTasksOnMinimumMachines;

public class Solution
{
    public static bool Function()
    {
        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(true);
    }

    private static void Run(bool expectedResult)
    {
        bool result = Solution.Function();
        Utilities.PrintSolution(true, result);
        Assert.AreEqual(expectedResult, result);
    }
}
