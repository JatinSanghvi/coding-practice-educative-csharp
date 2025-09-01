// Find the Kth Largest Integer in the Array
// =========================================
//
// Given an array of strings, `nums`, where each string represents an integer without leading zeros, and an integer `k`,
// your task is to find and return the string representing the kth largest integer in the array.
//
// > Note: Treat duplicate integers as distinct entities. For instance, if `nums` = ["2", "3", "3"], the first largest
// > integer is "3", the second largest is also "3", and the third largest is "2".
//
// Constraints:
//
// - 1 ≤ k ≤ `nums.length` ≤ 10^3
// - 1 ≤ `nums[i].length` ≤ 100
// - `nums[i]` consists of only digits.
// - `nums[i]` will not have any leading zeros.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P10_FindTheKthLargestIntegerInTheArray;

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
