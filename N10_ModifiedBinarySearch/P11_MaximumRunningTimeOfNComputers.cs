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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P11_MaximumRunningTimeOfNComputers;

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
