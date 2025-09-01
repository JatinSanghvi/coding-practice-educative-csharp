// Maximum Value at a Given Index in a Bounded Array
// =================================================
//
// Given three positive integers, `n`, `index`, and `maxSum`, output the `nums[index]` by constructing an array of
// `nums` with the length of `n`, which satisfies the following conditions:
//
// - The length of the array `nums` is equal to `n`.
// - Each element `nums[i]` is a positive integer, where 1 ≤ `i` < `n`.
// - The absolute difference between two consecutive elements, `nums[i]` and `nums[i+1]`, is at most 1.
// - The sum of all elements in `nums` does not exceed `maxSum`.
// - The element at `nums[index]` contains the maximum value.
//
// Constraints:
//
// - 1 ≤ `n` ≤ `maxSum` ≤ 10^9
// - 0 ≤ `index` < `n`

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P07_MaximumValueAtAGivenIndexInABoundedArray;

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
