// Minimum Cost to Hire K Workers
// ==============================
//
// You are given n workers, each characterized by two attributes:
//
// - `quality[i]`: Represents the work quality of the i-th worker.
// - `wage[i]`: Represents the minimum wage expectation of the i-th worker.
//
// You want to hire exactly `k` workers to form a paid group, and you must follow these payment rules:
//
// 1. Wage expectation: Every worker in the group must be paid at least their minimum wage expectation.
// 2. Proportional pay: The pay for each worker must be directly proportional to their quality. For example, if one
//    worker's quality is twice that of another, they must be paid twice as much.
//
// Your goal is to determine the least amount of money required to hire exactly `k` workers while satisfying the above
// conditions.
//
// Constraints
//
// - `n` == `quality.length` == `wage.length`
// - 1 ≤ k ≤ n ≤ 10^3
// - 1 ≤ `quality[i]`, `wage[i]` ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P08_MinimumCostToHireKWorkers;

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
