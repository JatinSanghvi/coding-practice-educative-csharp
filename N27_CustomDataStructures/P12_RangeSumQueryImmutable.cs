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

// Space complexity: O(n).
public class NumArray
{
    private readonly int[] sums;

    // Time complexity: O(n).
    public NumArray(int[] nums)
    {
        sums = new int[nums.Length + 1];
        for (int i = 0; i != nums.Length; i++)
        {
            sums[i + 1] = sums[i] + nums[i];
        }
    }

    // Time complexity: O(1).
    public int SumRange(int i, int j)
    {
        return sums[j + 1] - sums[i];
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3], [(0, 0), (0, 1), (0, 2), (1, 1), (1, 2), (2, 2)], [1, 3, 6, 2, 5, 3]);
    }

    private static void Run(int[] nums, (int, int)[] sumRangeArgs, int[] expectedResults)
    {
        var numArray = new NumArray(nums);

        for (int index = 0; index != sumRangeArgs.Length; index++)
        {
            (int i, int j) = sumRangeArgs[index];
            int result = numArray.SumRange(i, j);
            Utilities.PrintSolution((i, j), result);
            Assert.AreEqual(expectedResults[index], result);
        }
    }
}
