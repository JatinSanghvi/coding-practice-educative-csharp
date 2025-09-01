// Divide Chocolate
// ================
//
// You have a chocolate bar made up of several chunks, and each chunk has a certain sweetness, given in an array called
// `sweetness`. You want to share the chocolate with `k` friends. To do that, you'll make `k` cuts to divide the bar
// into `k + 1` parts. Each part will have chunks that are next to each other.
//
// Being a kind person, you'll take the piece with the minimum total sweetness and give the other parts to your friends.
// Find and return the maximum possible minimum sweetness you can get if you cut the chocolate optimally.
//
// Constraints:
//
// - 0 ≤ `k` < `sweetness.length` ≤ 10^3
// - 1 ≤ `sweetness[i]` ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P13_DivideChocolate;

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
