// Maximum Swap
// ============
//
// Given an integer `num`, return the maximum number that can be formed by swapping at least two digits once.
//
// Constraints:
//
// - 0 ≤ `num` ≤ 10^5

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P10_MaximumSwap;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static int MaximumSwap(int num)
    {
        char[] digits = num.ToString().ToCharArray();

        // Locate index with digit smaller than its right.
        int split;
        for (split = 0; split != digits.Length - 1 && digits[split] >= digits[split + 1]; split++) ;

        if (split != digits.Length - 1)
        {
            // Locate largest digit on the right-side, preferring the least significant one in case of a tie.
            int right = split + 1;
            for (int i = split + 2; i != digits.Length; i++)
            {
                if (digits[right] <= digits[i])
                {
                    right = i;
                }
            }

            // Locate the most significant smaller digit.
            int left;
            for (left = 0; digits[left] >= digits[right]; left++) ;

            (digits[left], digits[right]) = (digits[right], digits[left]);
        }

        return int.Parse(new string(digits));
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(53241, 54231);
        Run(42313, 43312);
    }

    private static void Run(int num, int expectedResult)
    {
        int result = Solution.MaximumSwap(num);
        Utilities.PrintSolution(num, result);
        Assert.AreEqual(expectedResult, result);
    }
}
