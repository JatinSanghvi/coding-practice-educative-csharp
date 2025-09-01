// Longest Common Prefix
// =====================
//
// Given an array of strings, `strs`, write a function to find the longest common prefix string in `strs`. If there is
// no common prefix, return an empty string, `""`.
//
// Constraints:
//
// - 1 ≤ `strs.length` ≤ 200
// - 0 ≤ `strs[i].length` ≤ 200
// - `strs[i]` consists of only lowercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N23_Trie.P07_LongestCommonPrefix;

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
