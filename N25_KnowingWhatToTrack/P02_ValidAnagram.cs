// Valid Anagram
// =============
//
// Given two strings, `str1` and `str2`, check whether `str2` is an anagram of `str1`.
//
// An anagram is a word or phrase created by rearranging the letters of another word or phrase while utilizing each of
// the original letters exactly once.
//
// Constraints:
//
// - 1 ≤ `str1.length`, `str2.length` ≤ 10^3
// - `str1` and `str2` consist of only lowercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P02_ValidAnagram;

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
