// Minimum Number of Pushes to Type Word II
// ========================================
//
// The keys (numbered 2 to 9) on a telephone keypad are associated with specific groups of lowercase English letters.
//
// > Note: The keys 1, ∗, 0, and # do not map to any letters.
//
// In the above mapping, the key 2 is mapped with letters ["a", "b", "c"]; pressing it once types "a", pressing it twice
// types "b", and pressing it three times types "c".
//
// Any mapping is possible as long as each letter is assigned to exactly one key, and keys can be mapped to any number
// of distinct letters.
//
// Given a string, `word`, consisting of lowercase English letters, return the minimum number of pushes needed to type
// it after remapping the keys.
//
// > Note: No mapping is provided in the input. You can devise any mapping if needed.
//
// Constraints:
//
// - 1 ≤ `word.length` ≤ 10^3
// - `word` consists of only lowercase English letters.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P11_MinimumNumberOfPushesToTypeWordII;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int MinimumPushes(string word)
    {
        var counts = new int[26];
        foreach (char letter in word)
        {
            counts[letter - 'a']++;
        }

        Array.Sort(counts);

        int pushes = 0;
        for (int i = 0; i != 26; i++)
        {
            pushes += counts[i] * ((25 - i) / 8 + 1);
        }

        return pushes;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("zyxwvuts", 8);
        Run("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvabcdefghijklmnabcdef", 124); // 30 * 1 + 22 * 2 + 14 * 3 + 2 * 4
    }

    private static void Run(string word, int expectedResult)
    {
        int result = Solution.MinimumPushes(word);
        Utilities.PrintSolution(word, result);
        Assert.AreEqual(expectedResult, result);
    }
}
