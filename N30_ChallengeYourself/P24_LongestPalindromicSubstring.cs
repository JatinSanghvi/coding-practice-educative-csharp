// Longest Palindromic Substring
// =============================
//
// Given a string `s`, return the longest palindromic substring in `s`.
//
// > Note: If there are multiple valid palindromic substrings of the same length, return any of them.
//
// Constraints
//
// - 1 ≤ `s.length` ≤ 1000
// - `s` consist of only digits and English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P24_LongestPalindromicSubstring;

public class Solution
{
    // Time complexity: O(n^2), Space complexity: O(1).
    public static string LongestPalindrome(string s)
    {
        int longestStart = 0;
        int longestEnd = 0;

        for (int mid = 0; mid != s.Length; mid++)
        {
            int start, end;

            // Odd lengths.
            for (start = mid - 1, end = mid + 1; start != -1 && end != s.Length && s[start] == s[end]; start--, end++) ;

            if (end - start - 2 > longestEnd - longestStart)
            {
                longestStart = start + 1;
                longestEnd = end - 1;
            }

            // Even lengths.
            for (start = mid, end = mid + 1; start != -1 && end != s.Length && s[start] == s[end]; start--, end++) ;

            if (end - start - 2 > longestEnd - longestStart)
            {
                longestStart = start + 1;
                longestEnd = end - 1;
            }
        }

        return s[longestStart..(longestEnd + 1)];
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("abaabaa", "abaaba");
        Run("bbaabaa", "aabaa");
    }

    private static void Run(string s, string expectedResult)
    {
        string result = Solution.LongestPalindrome(s);
        Utilities.PrintSolution(s, result);
        Assert.AreEqual(expectedResult, result);
    }
}
