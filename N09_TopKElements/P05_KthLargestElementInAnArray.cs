// Kth Largest Element in an Array
// ===============================
//
// Find the kth largest element in an unsorted array.
//
// > Note: We need to find the kth largest element in the sorted order, not the kth distinct element.
//
// Constraints:
//
// - 1 ≤ k ≤ `nums.length` ≤ 10^3
// - -10^4 ≤ `nums[i]` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P05_KthLargestElementInAnArray;

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
