// Sort List
// =========
//
// Given the head of a linked list, return the list after sorting it in ascending order.
//
// Constraints:
//
// - The number of nodes in the list is in the range [0,1000].
// - -10^3 ≤ `Node.value` ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P13_SortList;

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
