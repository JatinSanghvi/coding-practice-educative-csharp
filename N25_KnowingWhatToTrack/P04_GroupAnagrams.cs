// Group Anagrams
// ==============
//
// Given a list of words or phrases, group the words that are anagrams of each other. An anagram is a word or phrase
// formed from another word by rearranging its letters.
//
// Constraints:
//
// - 1 ≤ `strs.length` ≤ 10^3
// - 0 ≤ `strs[i].length` ≤ 100
// - `strs[i]` consists of lowercase English letters.
//
// > Note: The order in which the output is displayed doesn't matter.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P04_GroupAnagrams;

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
