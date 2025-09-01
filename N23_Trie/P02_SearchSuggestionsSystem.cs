// Search Suggestions System
// =========================
//
// Given an array of strings called `products` and a word to search, design a system that, when each character of the
// searched word is typed, suggests at most three product names from `products`. Suggested products should share a
// common prefix with the searched word. If more than three products exist with a common prefix, return the three
// product names that appear first in lexicographical order.
//
// Return the suggested products, which will be a list of lists after each character of searched word is typed.
//
// Constraints:
//
// - 1 ≤ `products.length` ≤ 1000
// - 1 ≤ `products[i].length` ≤ 3000
// - 1 ≤ `sum(products[i].length)` ≤ 2×10^3
// - All the strings of products are unique.
// - `products[i]` consists of lowercase English letters.
// - 1 ≤ `searched word.length` ≤ 1000
// - The searched word consists of lowercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N23_Trie.P02_SearchSuggestionsSystem;

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
