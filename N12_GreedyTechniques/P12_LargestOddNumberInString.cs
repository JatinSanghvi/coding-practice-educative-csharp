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
    // Time complexity: O(n), Space complexity: O(1).
    public static string LargestOddNumber(string num)
    {
        int right;
        for (right = num.Length - 1; right != -1 && num[right] % 2 == 0; right--) ;
        return num[..(right + 1)];
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("2112", "211");
    }

    private static void Run(string num, string expectedResult)
    {
        string result = Solution.LargestOddNumber(num);
        Utilities.PrintSolution(num, result);
        Assert.AreEqual(expectedResult, result);
    }
}
