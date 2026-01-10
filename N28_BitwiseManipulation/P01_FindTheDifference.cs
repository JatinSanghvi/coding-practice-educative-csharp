// Find the Difference
// ===================
//
// Given two strings, `str1` and `str2`, find the index of the extra character that is present in only one of the
// strings.
//
// > Note: If multiple instances of the extra character exist, return the index of the first occurrence of the character
// > in the longer string.
//
// Constraints:
//
// - 0 ≤ `str1.length`, `str2.length` ≤ 1000
// - Either `str2.length` = `str1.length + 1`, or, `str1.length` = `str2.length + 1`
// - The strings consist of lowercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P01_FindTheDifference;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int ExtraCharacterIndex(string str1, string str2)
    {
        char xor = '\0';

        foreach (char ch in str1) { xor ^= ch; }
        foreach (char ch in str2) { xor ^= ch; }

        string longerStr = str1.Length > str2.Length ? str1 : str2;
        return longerStr.IndexOf(xor);
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("aabbcc", "abcab", 4);
        Run("", "a", 0);
    }

    private static void Run(string str1, string str2, int expectedResult)
    {
        int result = Solution.ExtraCharacterIndex(str1, str2);
        Utilities.PrintSolution((str1, str2), result);
        Assert.AreEqual(expectedResult, result);
    }
}
