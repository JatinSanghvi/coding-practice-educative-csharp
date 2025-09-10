// Construct Target Array With Multiple Sums
// ========================================
//
// You are given an array `target` of `n` integers.
//
// Starting from an array `arr` of size `n` where every element is `1`, you may perform the following operation any number
// of times:
//
// - Let `x` be the sum of all current elements in `arr`.
// - Pick an index `i` and set `arr[i] = x`.
//
// Your task is to return True if it's possible to construct `target` from `arr`, otherwise return False.
//
// Constraints:
//
// - n == `target.length`
// - 1 ≤ `n` ≤ 1000
// - 1 ≤ `target[i]` ≤ 10^5

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P12_ConstructTargetArrayWithMultipleSums;

public class Solution
{
    // Time complexity: O(n*logn), Space complexity: O(n).
    public static bool IsPossible(int[] target)
    {
        // Using a simple approach, since the heap-based solution is far too complicated.
        Array.Sort(target);

        int oldSum = 1;
        int sum = target.Length;

        int i = 0;
        while (i < target.Length)
        {
            if (target[i] == 1) { i++; }
            else if (target[i] < sum) { return false; }
            else
            {
                if (target[i] == sum) { i++; }
                (oldSum, sum) = (sum, sum + sum - oldSum);
            }
        }

        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 1, 3, 1], false);
        Run([1, 1, 5, 17, 25], true);
    }

    private static void Run(int[] target, bool expectedResult)
    {
        bool result = Solution.IsPossible(target);
        Utilities.PrintSolution(target, result);
        Assert.AreEqual(expectedResult, result);
    }
}
