// K Empty Slots
// =============
//
// You are given n `bulbs` arranged in a row, numbered from 1 to n. Initially, all bulbs are turned off.
//
// Each day, exactly one bulb is switched on. You are given an array, `bulbs` of length n where `bulbs[i]` = x means
// that on day i + 1 (1‑indexed), the bulb at position x (also 1‑indexed) is turned on.
//
// So, given an integer `k`, determine the earliest day (the smallest day number) on which there are two bulbs that are
// on such that exactly `k` bulbs are off between them.
//
// If no such day exists, return -1.
//
// Constraints:
//
// - n == `bulbs.length`
// - 1 ≤ n ≤ 10^3
// - 1 ≤ `bulbs[i]` ≤ n
// - `bulbs` is a permutation of numbers from 1 to n
// - 0 ≤ k ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P14_KEmptySlots;

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
