// Maximum Running Time of N Computers
// ===================================
//
// You are given an integer, `n`, representing the number of computers, and a 0-indexed integer array, `batteries`,
// where `batteries[i]` denotes the number of minutes the i-th battery can power a computer.
//
// Your goal is to run all `n` computers simultaneously for the maximum possible number of minutes using the available
// batteries.
//
// Initially, you may assign at most one battery to each computer. After that, at any moment, you may remove a battery
// from a computer and replace it with another battery — either an unused battery or one taken from another computer.
// This replacement process can be repeated any number of times and takes no time.
//
// Each battery can power any computer multiple times, but only until it is completely drained. Batteries cannot be
// recharged.
//
// Return the maximum number of minutes you can run all `n` computers simultaneously.
//
// Constraints:
//
// - 1 ≤ `n` ≤ `batteries.length` ≤ 10^5
// - 1 ≤ `batteries[i]` ≤ 10^5

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P11_MaximumRunningTimeOfNComputers;

public class Solution
{
    // Time complexity: O(n*log(avg-capacity)), Space complexity: O(1).
    public long MaxRunTime(int[] batteries, int n)
    {
        long canRunMax = -1;
        long cannotRunMin = batteries.Select(capacity => (long)capacity).Sum() / n + 1;

        while (cannotRunMin - canRunMax != 1)
        {
            long mid = (canRunMax + cannotRunMin) / 2;

            if (CanRun(mid)) { canRunMax = mid; }
            else { cannotRunMin = mid; }
        }

        return canRunMax;

        bool CanRun(long time)
        {
            return batteries.Select(capacity => Math.Min(capacity, time)).Sum() >= n * time;
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([2, 2, 2], 2, 3);
        Run([1, 2, 5], 2, 3);
    }

    private static void Run(int[] batteries, int n, long expectedResult)
    {
        long result = new Solution().MaxRunTime(batteries, n);
        Utilities.PrintSolution((batteries, n), result);
        Assert.AreEqual(expectedResult, result);
    }
}
