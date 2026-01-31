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

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N23_Trie.P07_LongestCommonPrefix;

public class Solution
{
    // Time complexity: O(n*l), Space complexity: O(l), where l = max word length.
    public static string LongestCommonPrefix(string[] strs)
    {
        // Using Trie would not result in a straighforward or an optimal solution.
        List<char> prefix = strs[0].ToList();

        for (int i = 1; i != strs.Length; i++)
        {
            int j;
            for (j = 0; j != strs[i].Length; j++)
            {
                if (prefix.Count == j || prefix[j] != strs[i][j])
                {
                    break;
                }
            }

            prefix.RemoveRange(j, prefix.Count - j);
        }

        return string.Concat(prefix);
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(["abcd", "abdd"], "ab");
        Run(["abcd", "abc"], "abc");
    }

    private static void Run(string[] strs, string expectedResult)
    {
        string result = Solution.LongestCommonPrefix(strs);
        Utilities.PrintSolution(strs, result);
        Assert.AreEqual(expectedResult, result);
    }
}
