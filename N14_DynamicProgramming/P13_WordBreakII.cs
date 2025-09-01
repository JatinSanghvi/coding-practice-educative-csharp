// Word Break II
// =============
//
// You are given a string, `s`, and an array of strings, `wordDict`, representing a dictionary. Your task is to add
// spaces to `s` to break it up into a sequence of valid words from `wordDict`. We are required to return an array of
// all possible sequences of words (sentences). The order in which the sentences are listed is not significant.
//
// > Note: The same dictionary word may be reused multiple times in the segmentation.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 20
// - 1 ≤ `wordDict.length` ≤ 1000
// - 1 ≤ `wordDict[i].length` ≤ 10
// - `s` and `wordDict[i]` consist of only lowercase English letters.
// - All the strings of `wordDict` are unique.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P13_WordBreakII;

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
