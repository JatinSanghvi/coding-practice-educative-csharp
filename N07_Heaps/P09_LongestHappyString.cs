// Longest Happy String
// ====================
//
// A string is considered happy if it meets the following conditions:
//
// 1. It comprises only the characters `'a'`, `'b'`, and `'c'`.
// 2. It does not contain the substrings "aaa", "bbb", or "ccc".
// 3. The total occurrences of:
//    1. The character `'a'` does not exceed `a`.
//    2. The character `'b'` does not exceed `b`.
//    3. The character `'c'` does not exceed `c`.
//
// You are given three integers, `a`, `b`, and `c`, representing the maximum allowable occurrences of `'a'`, `'b'`, and
// `'c'`, respectively. Your task is to return the longest possible happy string. If there are multiple valid longest
// happy strings, return any one of them. If no such string can be formed, return an empty string "".
//
// Note: A substring is a contiguous sequence of characters within a string.
//
// Constraints:
//
// - 0 ≤ `a`, `b`, `c` ≤ 100
// - a + b + c > 0

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P09_LongestHappyString;

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
