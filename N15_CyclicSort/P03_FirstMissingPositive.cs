// First Missing Positive
// ======================
//
// Given an unsorted integer array, `nums`, return the smallest missing positive integer. Create an algorithm that runs
// with an O(n) time complexity and utilizes a constant amount of space.
//
// > Note: The smallest missing positive isn't the first positive number that's missing in the range of elements in the
// > input, but the first positive number that's missing if we start from 1.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^5
// - -2^31 ≤ `nums[i]` ≤ 2^31 - 1

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N15_CyclicSort.P03_FirstMissingPositive;

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
