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

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P05_IsomorphicStrings;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static bool IsIsomorphic(string string1, string string2)
    {
        if (string1.Length != string2.Length) { return false; }

        var forwardMap = new Dictionary<char, char>();
        var reverseMap = new Dictionary<char, char>();

        for (int i = 0; i != string1.Length; i++)
        {
            char ch1 = string1[i];
            char ch2 = string2[i];

            char ch;
            if (forwardMap.TryGetValue(ch1, out ch) && ch != ch2)
            {
                return false;
            }

            if (reverseMap.TryGetValue(ch2, out ch) && ch != ch1)
            {
                return false;
            }

            forwardMap[ch1] = ch2;
            reverseMap[ch2] = ch1;
        }

        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("hello", "teddy", true);
        Run("hello", "world", false);
        Run("world", "hello", false);
    }

    private static void Run(string string1, string string2, bool expectedResult)
    {
        bool result = Solution.IsIsomorphic(string1, string2);
        Utilities.PrintSolution((string1, string2), result);
        Assert.AreEqual(expectedResult, result);
    }
}
