// Minimum Operations to Make All Array Elements Equal
// ===================================================
//
// You are given an array, `nums`, consisting of positive integers of size `n` and another array `queries` of size `m`.
// For each query i in `queries`, the goal is to make all elements of `nums` equal to `queries[i]`. To achieve this, you
// can perform the following operation any number of times:
//
// - Increase or decrease an element of `nums` by 1.
//
// Return an array `answer` of size `m`, where `answer[i]` is the minimum number of operations needed to make all
// elements of `nums` equal to `queries[i]`. After processing each query, the `nums` array is reset to its original
// state.
//
// Constraints
//
// - n == `nums.length`
// - m == `queries.length`
// - 1 ≤ `n`, `m` ≤ 10^3
// - 1 ≤ `nums[i]`, `queries[i]` ≤ 10^5

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N17_SortAndSearch.P06_MinimumOperationsToMakeAllArrayElementsEqual;

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
