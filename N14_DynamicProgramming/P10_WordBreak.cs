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

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P10_WordBreak;

public class Solution
{
    // Time complexity: O(400s) + O(w * l) where w = word-count, l = avg-word-length.
    // Space complexity: O(s).
    public static bool WordBreak(string s, List<string> wordDict)
    {
        var words = new HashSet<string>(wordDict); // O(w * l)
        var solvables = new bool[s.Length + 1];
        solvables[0] = true;

        for (int end = 1; end != s.Length + 1; end++) // O(s)
        {
            for (int start = end - 1; start != -1 && start != end - 21; start--) // O(20)
            {
                if (solvables[start] && words.Contains(s[start..end])) // O(20)
                {
                    solvables[end] = true;
                    break;
                }
            }
        }

        return solvables[s.Length];
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("tearear", ["ear", "tea", "are"], false);
        Run("tearear", ["ear", "tear", "are"], true);
        Run("tearear", ["rear", "tea", "are"], true);
    }

    private static void Run(string s, string[] wordDict, bool expectedResult)
    {
        bool result = Solution.WordBreak(s, wordDict.ToList());
        Utilities.PrintSolution((s, wordDict), result);
        Assert.AreEqual(expectedResult, result);
    }
}
