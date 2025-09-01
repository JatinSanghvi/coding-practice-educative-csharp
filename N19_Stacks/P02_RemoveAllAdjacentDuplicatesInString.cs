// Remove All Adjacent Duplicates In String
// ========================================
//
// You are given a string consisting of lowercase English letters. Repeatedly remove adjacent duplicate letters, one
// pair at a time. Both members of a pair of adjacent duplicate letters need to be removed.
//
// Constraints:
//
// - 1 ≤ `string.length` ≤ 10^3
// - `string` consists of lowercase English alphabets.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N19_Stacks.P02_RemoveAllAdjacentDuplicatesInString;

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
