// Longest Palindrome by Concatenating Two-Letter Words
// ====================================================
//
// Suppose you are given an array of strings, `words`, and each element in the array has a length of two. You need to
// return the length of the longest palindrome that can be made by concatenating some elements from `words`. If no
// palindrome can be made, return 0.
//
// A palindrome is a sequence of characters that reads the same forward and backward.
//
// Constraints:
//
// - 1 ≤ `words.length` ≤ 10^6
// - `words[i].length` = 2
// - Each word can be used at most once.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P08_LongestPalindromeByConcatenatingTwoLetterWords;

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
