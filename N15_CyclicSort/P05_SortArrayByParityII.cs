// Sort Array By Parity II
// =======================
//
// You are given an integer, array `nums`, where exactly half of the elements are even, and the other half are odd.
//
// Rearrange `nums` such that:
//
// - All even numbers are placed at even indexes [0, 2, 4, ...].
// - All odd numbers are placed at odd indexes [1, 3, 5, ...].
//
// Constraints:
//
// - 2 ≤ `nums.length` ≤ 10^3
// - `nums.length` is even.
// - Half of the integers in `nums` are even.
// - 0 ≤ `nums[i]` ≤ 1000

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N15_CyclicSort.P05_SortArrayByParityII;

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
