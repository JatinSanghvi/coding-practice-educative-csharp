// N-th Tribonacci Number
// ======================
//
// Given a number `n`, calculate the corresponding Tribonacci number. The Tribonacci sequence Tn is defined as:
//
// T0 = 0, T1 = 1, T2 = 1, and Tn+3 = Tn + Tn+1 + Tn+2, for n >= 0
//
// The input number, `n`, is a non-negative integer.
//
// Constraints:
//
// - 0 ≤ `n` ≤ 37
// - The answer is guaranteed to fit within a 32-bit integer, i.e., answer ≤ 2^31 - 1

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P03_NthTribonacciNumber;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int FindTribonacci(int n)
    {
        var tribonaccis = new int[] { 0, 1, 1 };

        int i = 2;
        while (i < n)
        {
            i++;
            int temp = tribonaccis[2] + tribonaccis[1] + tribonaccis[0];
            tribonaccis[0] = tribonaccis[1];
            tribonaccis[1] = tribonaccis[2];
            tribonaccis[2] = temp;
        }

        return tribonaccis[n + 2 - i];
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(1, 1);
        Run(4, 4);
    }

    private static void Run(int n, int expectedResult)
    {
        int result = Solution.FindTribonacci(n);
        Utilities.PrintSolution(n, result);
        Assert.AreEqual(expectedResult, result);
    }
}
