// Find The K-th Lucky Number
// ==========================
//
// A number is called lucky if it comprises only the digits 4 and 7. Your task is to return the k-th lucky number as a
// string for a given integer `k`.
//
// Constraints:
//
// - 1 <= `k` <= 10^9

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P08_FindTheKthLuckyNumber;

public class Solution
{
    // Time complexity: O(logk), Space complexity: O(logk).
    public static string KthLuckyNumber(int k)
    {
        k--;

        var stack = new Stack<char>();
        while (k != -1)
        {
            stack.Push(k % 2 == 0 ? '4' : '7');
            k = k / 2 - 1;
        }

        return new string(stack.ToArray());
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(1, "4");
        Run(6, "77");
        Run(7, "444");
    }

    private static void Run(int k, string expectedResult)
    {
        string result = Solution.KthLuckyNumber(k);
        Utilities.PrintSolution(k, result);
        Assert.AreEqual(expectedResult, result);
    }
}
