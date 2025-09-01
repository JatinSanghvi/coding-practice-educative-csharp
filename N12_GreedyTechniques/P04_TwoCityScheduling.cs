// Two City Scheduling
// ===================
//
// A recruiter plans to hire n people and conducts their interviews at two different locations of the company. He
// evaluates the cost of inviting candidates to both these locations. The plan is to invite 50% at one location, and the
// rest at the other location, keeping costs to a minimum.
//
// We are given an array, `costs`, where `costs[i] = [aCost_i, bCost_i]`, the cost of inviting the i-th person to City A
// is `aCost_i`, and the cost of inviting the same person to City B is `bCost_i`.
//
// You need to determine the minimum cost to invite all the candidates for the interview such that exactly n/2 people
// are invited in each city.
//
// Constraints:
//
// - 2 ≤ `costs.length` ≤ 100
// - `costs.length` is even
// - 1 ≤ `aCost_i`, `bCost_i` ≤ 1000

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P04_TwoCityScheduling;

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
