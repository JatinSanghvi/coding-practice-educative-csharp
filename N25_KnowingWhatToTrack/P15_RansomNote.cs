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
