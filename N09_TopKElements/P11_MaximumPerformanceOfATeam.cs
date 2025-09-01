// Maximum Performance of a Team
// =============================
//
// You are given two integers, `n` and `k`, and two integer arrays, `speed` and `efficiency`, both of length `n`. There
// are `n` engineers numbered from `1` to `n`. The value `speed[i]` represents the speed of the i-th engineer, and
// `efficiency[i]` represents their efficiency.
//
// To form a team with the maximum performance, you need to select at most `k` different engineers from the `n`
// engineers.
//
// The performance of a team is calculated as follows:
//
// The sum of the selected engineers' speeds × the minimum efficiency among the selected engineers
//
// Return the maximum performance of the team. As the result can be a very large number, return it modulo (10^9 + 7).
//
// Constraints:
//
// - 1 ≤ k ≤ n ≤ 10^3
// - `speed.length` == `n`
// - `efficiency.length` == `n`
// - 1 ≤ `speed[i]` ≤ 10^3
// - 1 ≤ `efficiency[i]` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P11_MaximumPerformanceOfATeam;

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
