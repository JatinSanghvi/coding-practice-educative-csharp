// Divide Chocolate
// ================
//
// You have a chocolate bar made up of several chunks, and each chunk has a certain sweetness, given in an array called
// `sweetness`. You want to share the chocolate with `k` friends. To do that, you'll make `k` cuts to divide the bar
// into `k + 1` parts. Each part will have chunks that are next to each other.
//
// Being a kind person, you'll take the piece with the minimum total sweetness and give the other parts to your friends.
// Find and return the maximum possible minimum sweetness you can get if you cut the chocolate optimally.
//
// Constraints:
//
// - 0 ≤ `k` < `sweetness.length` ≤ 10^3
// - 1 ≤ `sweetness[i]` ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P13_DivideChocolate;

public class Solution
{
    // Time complexity: O(nlog(result)), Space complexity: O(1).
    public int MaximizeSweetness(int[] sweetness, int k)
    {
        int testValue;
        for (testValue = 2; IsPossible(testValue); testValue *= 2) ;

        int minImpossible = testValue;
        int maxPossible = testValue / 2;

        while (minImpossible - maxPossible != 1)
        {
            testValue = (maxPossible + minImpossible) / 2;
            if (IsPossible(testValue)) { maxPossible = testValue; }
            else { minImpossible = testValue; }
        }

        return maxPossible;

        bool IsPossible(int testValue)
        {
            int pieces = 0;
            int sum = 0;
            for (int i = 0; i != sweetness.Length && pieces != k + 1; i++)
            {
                sum += sweetness[i];
                if (sum >= testValue)
                {
                    pieces++;
                    sum = 0;
                }
            }

            return pieces == k + 1;
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 1, 3, 1, 4], 2, 4);
        Run([1, 2, 1, 3, 1, 4], 3, 1);
        Run([1, 2, 1, 3, 1, 4], 5, 1);
    }

    private static void Run(int[] sweetness, int k, int expectedResult)
    {
        int result = new Solution().MaximizeSweetness(sweetness, k);
        Utilities.PrintSolution((sweetness, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
