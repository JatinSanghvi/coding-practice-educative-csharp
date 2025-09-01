// Word Ladder
// ===========
//
// Given two words, `src` and `dest`, and a list, `words`, return the number of words in the shortest transformation
// sequence from `src` to `dest`. If no such sequence can be formed, return 0.
//
// A transformation sequence is a sequence of words (`src` → word_1 → word_2 → word_3 ... → word_j ) that has the
// following properties:
//
// - word_j = `dest`
// - Every pair of consecutive words differs by a single character.
// - All the words in the sequence are present in the `words`. The `src` does not need to be present in `words`.
//
// Constraints:
//
// - 1 ≤ `src.length` ≤ 10
// - `src.length` = `dest.length` = `words[i].length`
// - `src` ≠ `dest`
// - 1 ≤ `words.length` ≤ 5000
// - No duplicates in the `words`
// - `src`, `dest`, and `words[i]` consist of lowercase English characters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N22_TreeBreadthFirstSearch.P06_WordLadder;

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
