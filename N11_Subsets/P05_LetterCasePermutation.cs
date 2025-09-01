// Letter Case Permutation
// =======================
//
// Given a string, `s`, consisting of letters and digits, generate all possible variations by modifying each letter
// independently to be either lowercase or uppercase while keeping the digits unchanged. Each letter in the `s` string
// can appear in both cases across different variations, resulting in multiple possible combinations. Return a list
// containing all such variations in any order.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 12
//
// - `s` consists of lowercase English letters, uppercase English letters, and digits.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N11_Subsets.P05_LetterCasePermutation;

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
