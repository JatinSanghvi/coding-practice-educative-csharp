// Verifying an Alien Dictionary
// =============================
//
// In an alien language, the alphabet consists of the same lowercase English letters but arranged in a different order.
//
// Given a list of words, `words`, written in this alien language, and a string `order` representing the order of the
// alien alphabet (as a permutation of lowercase letters), return TRUE if the words are sorted lexicographically
// according to `order`; otherwise, return FALSE.
//
// > Note: A word `a` is considered lexicographically smaller than word `b` if:
//
// > - At the first position where the two words differ, the character in `a` comes before the character in `b` in the
// >   given `order` string.
//
// > - If one word is a prefix of the other (and all compared characters are the same), then the shorter word is
// >   considered smaller.
//
// Constraints:
//
// - 1 ≤ `words.length` ≤ 10^3
// - 1 ≤ `words[i].length` ≤ 20
// - `order.length` == 26
// - All the characters in `words[i]` and `order` are lowercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N16_TopologicalSort.P03_VerifyingAnAlienDictionary;

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
