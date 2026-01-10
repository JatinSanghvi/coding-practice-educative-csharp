// Sum of All Subset XOR Totals
// ============================
//
// Given an array of integers, `nums`, compute and return the sum of XOR totals for all its possible subsets.
//
// - A subset is any combination of elements from the original array, `nums`. This includes the empty subset (containing
//   no elements) and the subset that includes all array elements.
// - The XOR total of a subset results from applying the XOR operation to all the elements in that subset.
//
// > Note: If the `nums` array has duplicate elements, then subsets that contain the same elements but with different
// > indexes are treated as separate. Each subset's XOR total is counted in the final sum.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 12
// - 1 ≤ `nums[i]` ≤ 20

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P07_SumOfAllSubsetXORTotals;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int XorTotalsSum(int[] nums)
    {
        // There are total 2^n sets. Every number is part of exactly half of these sets. Let's divide the sets into two parts,
        // s0: not containing some number x, and s1: containing the number. Let's assume that there k sets in s0 having
        // 0 at bit position b in their XOR results. If x has a 1 at bit position b, it will tranform the bits from 0 to
        // 1 in k sets in s1 and 1 to 0 in the rest. In effect, total 1s at bit position b in XOR results across both
        // sets, s0 and s1 will end up being 2^(n-1).
        //
        // Expanding on this, we can say that whatever be the values of the remaining numbers and their XOR sums, if any
        // of the numbers have a 1 at bit position b, there will be exactly 2^(n-1) 1s across all XOR results at that
        // bit position. Also, if none of the numbers has a 1 at bit position b, all 2^n XOR results will have 0 at that
        // position.
        //
        // Hence, the answer ends up being equal to the OR result of all the numbers in the array times 2^(n-1).

        int result = 0;

        foreach (int num in nums)
        {
            result |= num;
        }

        return result << (nums.Length - 1);
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([10], 10);
        Run([5, 10], 30);
        Run([8, 8, 10], 40);
    }

    private static void Run(int[] nums, int expectedResult)
    {
        int result = Solution.XorTotalsSum(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}
