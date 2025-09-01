// Largest Odd Number in String
// ============================
//
// You are given a string, `num`, which represents a large integer. Your task is to find the largest odd-valued integer
// that can be formed as a non-empty substring of `num`. Return this odd integer as a string. If no odd integer exists,
// return an empty string (`""`).
//
// Note: A substring is a continuous sequence of characters within a string.
//
// Constraints:
//
// - 1 ≤ `num.length` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P12_LargestOddNumberInString;

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
