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

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P10_SplitAStringIntoTheMaxNumberOfUniqueSubstrings;

public class Solution
{
    // Time complexity: O(2^n), Space complexity: O(n).
    public static int MaxUniqueSplitFunc(string s)
    {
        var substrings = new HashSet<string>();
        return Solve(0);

        int Solve(int start)
        {
            if (start == s.Length) { return 0; }

            int maxCount = 0;
            for (int end = start + 1; end != s.Length + 1; end++)
            {
                string sub = s[start..end];
                if (!substrings.Contains(sub))
                {
                    substrings.Add(sub);
                    maxCount = Math.Max(maxCount, Solve(end) + 1);
                    substrings.Remove(sub);
                }
            }

            return maxCount;
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("banana", 4);
    }

    private static void Run(string s, int expectedResult)
    {
        int result = Solution.MaxUniqueSplitFunc(s);
        Utilities.PrintSolution(s, result);
        Assert.AreEqual(expectedResult, result);
    }
}
