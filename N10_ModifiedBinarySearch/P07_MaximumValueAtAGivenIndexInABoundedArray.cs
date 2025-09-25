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
    // Time complexity: O(log(ans)), Space complexity: O(1).
    public static int MaxValue(int n, int index, int maxSum)
    {
        (int low, int high) = (1, 2);

        while (GetSum(n, high, index) <= maxSum)
        {
            (low, high) = (high, high * 2);
        }

        while (high - low != 1)
        {
            int mid = (low + high) / 2;

            if (GetSum(n, mid, index) <= maxSum) { low = mid; }
            else { high = mid; }
        }

        return low;
    }

    private static int GetSum(int length, int value, int index)
    {
        value--; // To simplify calculation.

        return length // Lower base.
            + value * value // Isosceles triangle area.
            - (index >= value - 1 ? 0 : (value - index - 1) * (value - index) / 2) // Extra area on left.
            - (index <= length - value ? 0 : (value - (length - index)) * (value - (length - index) + 1) / 2); // Extra area on right.
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(100, 90, 416, 20);
        Run(100, 90, 415, 19);
        Run(100, 9, 416, 20);
        Run(100, 9, 415, 19);
    }

    private static void Run(int n, int index, int maxSum, int expectedResult)
    {
        int result = Solution.MaxValue(n, index, maxSum);
        Utilities.PrintSolution((n, index, maxSum), result);
        Assert.AreEqual(expectedResult, result);
    }
}
