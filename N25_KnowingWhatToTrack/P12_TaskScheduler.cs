// Task Scheduler
// ==============
//
// You are given an array of CPU `tasks` represented by uppercase letters (A to Z) and an integer `n`, which denotes the
// cooling period required between any two identical tasks. Each task takes exactly one CPU interval to execute.
// Therefore, each CPU interval can either perform a task or remain idle. Tasks can be executed in any order, but the
// same task must be separated by at least `n` intervals.
//
// Determine the minimum number of CPU intervals required to complete all tasks.
//
// Constraints:
//
// - 1 ≤ `tasks.length` ≤ 1000
// - 0 ≤ `n` ≤ 100
// - `tasks` consists of uppercase English letters

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P12_TaskScheduler;

public class Solution
{
    public static int LeastInterval(char[] tasks, int n)
    {
        var counts = new int[26];
        foreach (char task in tasks)
        {
            counts[task - 'A']++;
        }

        Array.Sort(counts);
        int intervals = counts[25] - 1;
        int emptySlots = n * intervals;

        for (int i = 0; i != 25; i++)
        {
            emptySlots -= Math.Min(counts[i], intervals);
        }

        return Math.Max(0, emptySlots) + tasks.Length;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("ABABACACA".ToCharArray(), 0, 9);
        Run("ABABACACA".ToCharArray(), 1, 9);
        Run("ABABACACA".ToCharArray(), 2, 13);
    }

    private static void Run(char[] tasks, int n, int expectedResult)
    {
        int result = Solution.LeastInterval(tasks, n);
        Utilities.PrintSolution((tasks, n), result);
        Assert.AreEqual(expectedResult, result);
    }
}
