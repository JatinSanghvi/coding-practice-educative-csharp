// Sum of Mutated Array Closest to Target
// ======================================
//
// Given an integer array `arr` and a target value `target`, find an integer `value` such that if all the numbers in
// `arr` greater than `value` are replaced with a `value`, the sum of the array gets as close as possible to the
// `target`.
//
// Choose the smaller `value` if there's a tie (two `value` options are equally close to the target).
//
// > Note: The answer doesn't have to be a number from the array.
//
// Constraints:
//
// - 1 ≤ `arr.length` ≤ 10^3
// - 1 ≤ `arr[i]`, `target` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N17_SortAndSearch.P07_SumOfMutatedArrayClosestToTarget;

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
