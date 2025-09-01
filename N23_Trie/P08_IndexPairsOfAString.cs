// Index Pairs of a String
// =======================
//
// Given a string `text` and an array of strings `words`, return a list of all index pairs `[i, j]` such that the
// substring `text[i...j]` is present in `words`.
//
// Return the pairs `[i, j]` in a sorted order, first by the value of `i`, and if two pairs have the same `i`, by the
// value of `j`.
//
// Constraints:
//
// - 1 ≤ `text.length` ≤ 100
// - 1 ≤ `words.length` ≤ 20
// - 1 ≤ `words[i].length` ≤ 50
// - `text` and `words[i]` consist of lowercase English letters.
// - All the strings of `words` are unique.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N23_Trie.P08_IndexPairsOfAString;

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
