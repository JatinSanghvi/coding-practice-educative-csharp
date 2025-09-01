// H-Index
// =======
//
// You are given an array of integers `citations`, where each element `citations[i]` represents the number of citations
// received for the i-th publication of a researcher.
//
// Your task is to find the researcher's h-index and return the value of h.
//
// > Note: The h-index is defined as the highest number h such that the given researcher has published at least h
// > papers, each of which has been cited at least h times.
//
// Constraints:
//
// - n == `citations.length`
// - 1 ≤ n ≤ 1000
// - 0 ≤ `citations[i]` ≤ 1000

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N17_SortAndSearch.P14_HIndex;

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
