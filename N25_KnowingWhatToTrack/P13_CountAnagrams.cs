// Count Anagrams
// ==============
//
// You are given a string, `s`, containing one or more words separated by a single space. Your task is to count and
// return the number of distinct anagrams of the entire string `s`. As the answer may be very large, return it modulo
// 10^9 + 7, i.e., return the remainder when the answer is divided by 10^9 + 7.
//
// > Note: An anagram is a word formed by rearranging the letters of another word, using all the original letters
// > exactly once. For example, "listen" is an anagram of "silent". Similarly, a string `t` is an anagram of string `s`
// > if the `i``th` word of `t` is a permutation of the `i``th` word of `s`. For example, "silent era" is an anagram of
// > "listen ear", but "sline tear" is not.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 10^3
// - `s` consists of lowercase English letters and spaces `' '`.
// - There is only a single space between consecutive words.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P13_CountAnagrams;

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
