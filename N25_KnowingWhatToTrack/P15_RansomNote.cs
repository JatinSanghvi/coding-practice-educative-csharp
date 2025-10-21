// Ransom Note
// ===========
//
// Given two strings, `ransomNote` and `magazine`, check if `ransomNote` can be constructed using the letters from
// `magazine`. Return TRUE if it can be constructed, FALSE otherwise.
//
// > Note: A ransom note is a written message that can be constructed by using the letters available in the given
// > magazine. The magazine can have multiple instances of the same letter. Each instance of the letter in the magazine
// > can only be used once to construct the ransom note.
//
// Constraints:
//
// - 1 ≤ `ransomNote.length`, `magazine.length` ≤ 10^5
// - The `ransomNote` and `magazine` consist of lowercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P15_RansomNote;

public class Solution
{
    // Time complexity: O(n+m), Space complexity: O(1).
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        var counts = new int[26];

        foreach (char letter in ransomNote) { counts[letter - 'a']--; }
        foreach (char letter in magazine) { counts[letter - 'a']++; }

        foreach (int count in counts)
        {
            if (count < 0) { return false; }
        }

        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("hello", "holler", true);
        Run("hello", "whole", false);
    }

    private static void Run(string ransomNote, string magazine, bool expectedResult)
    {
        bool result = Solution.CanConstruct(ransomNote, magazine);
        Utilities.PrintSolution((ransomNote, magazine), result);
        Assert.AreEqual(expectedResult, result);
    }
}
