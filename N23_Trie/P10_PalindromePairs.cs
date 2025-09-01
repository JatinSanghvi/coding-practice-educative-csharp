// Palindrome Pairs
// ================
//
// You are given a *0-indexed array* of *unique strings* called `words`.
//
// A *palindrome pair* is defined as a pair of indexes `(i, j)` where both `i` and `j` are within the valid range of the
// list of `words` (that is, 0 ≤ `i`, `j` < `words.length`), and `i` is not equal to `j`. The key condition is that when
// the word at index `i` is concatenated with the word at index `j` (forming `words[i] + words[j]`), the resulting
// string must be a palindrome.
//
// Your task is to return *all valid palindrome pairs* as a list of index pairs.
//
// Additionally, your solution must have a time complexity of O(sum of `words.length`).
//
// Constraints:
//
// - 1 ≤ `words.length` ≤ 1000
// - 0 ≤ `words[i].length` ≤ 300
// - `words[i]` consists of lowercase English letters
// - All strings in `words` unique

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N23_Trie.P10_PalindromePairs;

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
