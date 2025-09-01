// Word Break
// ==========
//
// Given a string, `s`, and a dictionary of strings, `wordDict`, check if `s` can be segmented into a space-separated
// sequence of one or more dictionary words. If yes, return TRUE; else, return FALSE.
//
// > Note: The same word in the dictionary may be used multiple times.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 250
// - 1 ≤ `wordDict.length` ≤ 1000
// - 1 ≤ `wordDict[i].length` ≤ 20
// - `s` and `wordDict[i]` consist of only lowercase English letters.
// - All the strings of `wordDict` are unique.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P10_WordBreak;

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
