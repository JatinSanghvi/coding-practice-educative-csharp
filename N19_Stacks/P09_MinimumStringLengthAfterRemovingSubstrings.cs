// Minimum String Length After Removing Substrings
// ===============================================
//
// You are given a string, `s`, containing only uppercase English letters. You can perform operations on this string
// where, in each operation, you remove any occurrence of the substrings "AB" or "CD" from `s`.
//
// Your task is to return the shortest string length after applying all possible operations.
//
// > Note: After each removal, the string joins back together, potentially creating new occurrences of "AB" or "CD" that
// > can also be removed.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 100
// - `s` consists only of uppercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N19_Stacks.P09_MinimumStringLengthAfterRemovingSubstrings;

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
