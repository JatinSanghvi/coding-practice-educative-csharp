// Isomorphic Strings
// ==================
//
// Given two strings, check whether two strings are isomorphic to each other or not.  Two strings are isomorphic if a
// fixed mapping exists from the characters of one string to the characters of the other string. For example, if there
// are two instances of the character "a"  in the first string, both these instances should be converted to another
// character (which could also remain the same character if "a" is mapped to itself) in the second string. This
// converted character should remain the same in both positions of the second string since there is a fixed mapping from
// the character "a" in the first string to the converted character in the second string.
//
// > Note: Two different characters cannot map to the same character. Furthermore, all the instances of a character must
// > be replaced with another character while protecting the order of characters.
//
// Constraints:
//
// - Both the strings consist of valid ASCII characters.
// - The length of the string is 0 ≤ `length` ≤ 5 × 10^4.
// - The length of both strings is the same.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P05_IsomorphicStrings;

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
