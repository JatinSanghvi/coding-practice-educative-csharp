// Palindromic Substrings
// ======================
//
// Given a string, `s`, return the number of palindromic substrings contained in it. A substring is a contiguous
// sequence of characters in a string. A palindrome is a phrase, word, or sequence that reads the same forward and
// backward.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 1000
// - `s` consists of only lowercase English characters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P11_PalindromicSubstrings;

public class Solution
{
    // Time complexity: O(n^2), Space complexity: O(1).
    public static int CountPalindromicSubstrings(string s)
    {
        int count = s.Length;

        for (int mid = 0; mid != s.Length; mid++)
        {
            // Odd lengths.
            for (int left = mid - 1, right = mid + 1; left != -1 && right != s.Length && s[left] == s[right]; left--, right++)
            {
                count++;
            }

            // Even lengths.
            for (int left = mid, right = mid + 1; left != -1 && right != s.Length && s[left] == s[right]; left--, right++)
            {
                count++;
            }
        }

        return count;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("abbabc", 9);
    }

    private static void Run(string s, int expectedResult)
    {
        int result = Solution.CountPalindromicSubstrings(s);
        Utilities.PrintSolution(s, result);
        Assert.AreEqual(expectedResult, result);
    }
}
