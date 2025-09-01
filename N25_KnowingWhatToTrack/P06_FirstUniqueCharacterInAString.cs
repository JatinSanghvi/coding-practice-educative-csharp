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
