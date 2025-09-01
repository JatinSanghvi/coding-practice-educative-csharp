// Jump Game
// =========
//
// You are given an integer array `nums`, where each element represents the maximum number of steps you can move forward
// from that position. You always start at index 0 (the first element), and at each step, you may jump to any of the
// next positions within the range allowed by the current element's value. Return TRUE if you can reach the last index,
// or FALSE otherwise.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - 0 ≤ `nums[i]` ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P01_JumpGame;

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
