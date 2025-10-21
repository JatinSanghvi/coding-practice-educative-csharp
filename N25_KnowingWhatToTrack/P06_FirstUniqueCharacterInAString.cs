// First Unique Character in a String
// ==================================
//
// For a given string of characters, `s`, your task is to find the first non-repeating character and return its index.
// Return -1 if there's no unique character in the given string.
//
// Constraints:
//
// - Only lowercase English letters are accepted.
// - There are no spaces in the string.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P06_FirstUniqueCharacterInAString;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int FirstUniqueChar(string s)
    {
        var counts = new int[26];
        foreach (char letter in s)
        {
            counts[letter - 'a']++;
        }

        for (int i = 0; i != s.Length; i++)
        {
            char letter = s[i];
            if (counts[letter - 'a'] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("abcdabc", 3);
        Run("abcdabcd", -1);
    }

    private static void Run(string s, int expectedResult)
    {
        int result = Solution.FirstUniqueChar(s);
        Utilities.PrintSolution(s, result);
        Assert.AreEqual(expectedResult, result);
    }
}
