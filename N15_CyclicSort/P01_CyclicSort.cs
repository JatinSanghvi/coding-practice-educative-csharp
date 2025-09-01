// Cyclic Sort
// ===========
//
// You are given an integer array, `nums` of size n, where each number is distinct and falls within the range [1, n].
// Your task is to sort the array in place while ensuring a time complexity of O(n) and using only O(1) extra space.
//
// Constraints:
//
// - n == `nums.length`
// - 1 ≤ n ≤ 10^3
// - Each element in `nums` is unique and within the range [1, n].

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N15_CyclicSort.P01_CyclicSort;

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
