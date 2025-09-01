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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P01_PalindromePermutation;

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
