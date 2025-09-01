// Range Sum Query - Immutable
// ===========================
//
// You are given an integer array, `nums`, and you need to handle multiple queries of the following type:
//
// - Query: Calculate the sum of elements in `nums` between indices `i` and `j` (inclusive), where `i ≤ j`.
//
// Implement the `NumArray` class to support the following operations efficiently:
//
// - Constructor: Initializes the object with the integer array `nums`.
//
// - sumRange(i, j): Returns the sum of the elements of `nums` between indices `i` and `j` (inclusive), i.e., the sum of
//   `nums[i] + nums[i + 1] + ... + nums[j]`.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - -10^5 ≤ `nums[i]` ≤ 10^5
// - 0 ≤ `i` ≤ `j` < `nums.length`
// - At most, 10^3 calls will be made to `sumRange`.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P12_RangeSumQueryImmutable;

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
