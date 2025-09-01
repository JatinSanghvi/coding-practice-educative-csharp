// Longest Substring without Repeating Characters
// ==============================================
//
// Given a string, `str`, return the length of the longest substring without repeating characters.
//
// Constraints:
//
// - 1 ≤ `str.length` ≤ 1000
// - `str` consists of English letters, digits, and spaces.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P06_LongestSubstringWithoutRepeatingCharacters;

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
