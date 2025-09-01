// Subsets
// =======
//
// Given an array of integers, `nums`, find all possible subsets of `nums`, including the empty set.
//
// > Note: The solution set must not contain duplicate subsets. You can return the solution in any order.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10
//
// - -10 ≤ `nums[i]` ≤ 10
//
// - All the numbers of `nums` are unique.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N11_Subsets.P01_Subsets;

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
