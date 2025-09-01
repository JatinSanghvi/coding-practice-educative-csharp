// Split a String Into the Max Number of Unique Substrings
// =======================================================
//
// Given a string, `s`, determine the maximum number of unique substrings into which `s` can be split. You can divide
// `s` into any sequence of nonempty substrings, ensuring their concatenation reconstructs the original string. However,
// each substring in the split must be distinct.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 16
// - `s` contains only lowercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P10_SplitAStringIntoTheMaxNumberOfUniqueSubstrings;

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
