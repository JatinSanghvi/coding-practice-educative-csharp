// Decode String
// =============
//
// Given an encoded string, return its decoded version. The encoding rule follows the pattern: k[encoded string], where
// the encoded string is repeated exactly k times.
//
// > Note: The k is guaranteed to be a positive integer.
//
// Assume that the input string is always valid, meaning there are no extra spaces, and the square brackets are properly
// balanced and well-formed. Additionally, assume that the original data contains no digits and that digits are only
// used for repeating the string.
//
// For example, the input will not contain patterns like 3a or 2[4], whereas a valid pattern is 2[aj]3[bax].
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 30
// - 1 ≤ k ≤ 100
// - `s` consists of lowercase English letters, digits, and square brackets.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N19_Stacks.P08_DecodeString;

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
