// Top K Frequent Words
// ====================
//
// Given a list of strings `words` and an integer `k`, return the `k` most frequently occurring strings.
//
// > Note: The result should be sorted in descending order based on frequency. If multiple words have the same
// > frequency, they should be sorted in lexicographical order.
//
// Constraints:
//
// - 1 ≤ `words.length` ≤ 100
// - 1 ≤ `words[i].length` ≤ 10
// - 1 ≤ `k` ≤ number of unique words in the list
// - `words[i]` consists of lowercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N23_Trie.P06_TopKFrequentWords;

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
