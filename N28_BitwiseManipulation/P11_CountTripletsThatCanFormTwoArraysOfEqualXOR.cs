// Count Triplets That Can Form Two Arrays of Equal XOR
// ====================================================
//
// Given an array of integers, `arr`, we need to find three indices, `i`, `j`, and `k`, such that 0 ≤ `i` < `j` ≤ `k` <
// `arr.length`.
//
// We define two values, `a` and `b`, as follows:
// - `a = arr[i] ^ arr[i + 1] ^ ... ^ arr[j - 1]`
// - `b = arr[j] ^ arr[j + 1] ^ ... ^ arr[k]`
//
// > Note: ^ denotes the bitwise-xor operation.
//
// Return the count of triplets (`i`, `j`, `k`) for which `a` is equal to `b`.
//
// Constraints:
//
// - 1 ≤ `arr.length` ≤ 300
// - 1 ≤ `arr[i]` ≤ 1000

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P11_CountTripletsThatCanFormTwoArraysOfEqualXOR;

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
