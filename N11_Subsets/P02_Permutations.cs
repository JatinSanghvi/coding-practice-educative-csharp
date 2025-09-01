// Permutations
// ============
//
// Given an input string, return all possible permutations of the string.
//
// > Note: The order of permutations does not matter.
//
// Constraints:
//
// - All characters in `word` are unique.
//
// - 1 ≤ `word.length` ≤ 6
//
// - All characters in `word` are lowercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N11_Subsets.P02_Permutations;

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
