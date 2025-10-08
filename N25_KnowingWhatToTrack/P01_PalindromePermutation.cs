// Palindrome Permutation
// ======================
//
// For a given string, `st`, find whether or not a permutation of this string is a palindrome. You should return TRUE if
// such a permutation is possible and FALSE if it isn't possible.
//
// Constraints:
//
// - 1 ≤ `st.length` ≤ 1000
// - The string will contain lowercase English letters.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P01_PalindromePermutation;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static bool PermutedPalindrome(string st)
    {
        var counts = new Dictionary<char, int>();

        foreach (char ch in st)
        {
            counts.TryAdd(ch, 0);
            counts[ch]++;
        }

        int oddCounts = 0;
        foreach ((char ch, int count) in counts)
        {
            if (count % 2 != 0) { oddCounts++; }
        }

        return oddCounts == 0 || oddCounts == 1;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("aabbccc", true);
        Run("abbbccc", false);
    }

    private static void Run(string st, bool expectedResult)
    {
        bool result = Solution.PermutedPalindrome(st);
        Utilities.PrintSolution(st, result);
        Assert.AreEqual(expectedResult, result);
    }
}
