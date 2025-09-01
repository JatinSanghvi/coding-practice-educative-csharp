// Maximal Score After Applying K Operations
// =========================================
//
// You are given a 0-indexed array of integer `nums` and an integer `k`. Your task is to maximize a score through a
// series of operations. Initially, your score is set to 0.
//
// In each operation:
//
// 1. Select an index `i` (where 0 ≤ i < `nums.length`).
// 2. Add the value of `nums[i]` to your score.
// 3. Replace `nums[i]` with `ceil(nums[i] / 3)`.
//
// Repeat this process exactly `k` times and return the highest score you can achieve.
//
// > The ceiling function `ceil(value)` is the least integer greater than or equal to `value`.
//
// Constraints:
//
// - 1 ≤ `nums.length`, k ≤ 10^3
// - 1 ≤ `nums[i]` ≤ 10^5

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P09_MaximalScoreAfterApplyingKOperations;

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
