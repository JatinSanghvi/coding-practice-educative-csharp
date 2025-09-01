// Find All Anagrams in a String
// =============================
//
// Given two strings, `a` and `b`, return an array of all the start indexes of anagrams of `b` in `a`. We may return the
// answer in any order.
//
// > An anagram is a word or phrase created by rearranging the letters of another word or phrase while utilizing each of
// > the original letters exactly once. For example, "act" is the anagram of "cat", and "flow" is the anagram of "wolf".
//
// Constraints:
//
// - 1 ≤ `a.length`, `b.length` ≤ 3 × 10^3
// - Both `a` and `b` consist only of lowercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P07_FindAllAnagramsInAString;

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
