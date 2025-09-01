// Russian Doll Envelopes
// ======================
//
// You are given a 2D array of integers, `envelopes`, where each element `envelopes[i] = [w_i, h_i]` represents the
// width and height of an envelope. An *envelope* can fit inside another if and only if its width and height are
// strictly smaller than the width and height of the other envelope. The task is to determine the maximum number of
// envelopes that can be nested inside each other, similar to Russian dolls.
//
// Constraints:
//
// - 1 ≤ `envelopes.length` ≤ 10^3
// - `envelopes[i].length` == 2
// - 1 ≤ `w_i`, `h_i` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N17_SortAndSearch.P12_RussianDollEnvelopes;

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
