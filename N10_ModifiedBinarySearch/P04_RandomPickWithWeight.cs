// Random Pick with Weight
// =======================
//
// You're given an array of positive integers, `weights`, where `weights[i]` is the weight of the i-th index.
//
// Write a function, Pick Index(), which performs weighted random selection to return an index from the `weights` array.
// The larger the value of `weights[i]`, the heavier the weight is, and the higher the chances of its index being
// picked.
//
// Suppose that the array consists of the weights [12, 84, 35]. In this case, the probabilities of picking the indexes
// will be as follows:
//
// - Index 0: 12 / (12 + 84 + 35) = 9.2%
// - Index 1: 84 / (12 + 84 + 35) = 64.1%
// - Index 2: 35 / (12 + 84 + 35) = 26.7%
//
// Constraints:
//
// - 1 ≤ `weights.length` ≤ 10^4
// - 1 ≤ `weights[i]` ≤ 10^5
// - Pick Index() will be called at most 10^4 times.
//
// > Note: Since we're randomly choosing from the options, there is no guarantee that in any specific run of the
// > program, any of the elements will be selected with the exact expected frequency.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P04_RandomPickWithWeight;

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
