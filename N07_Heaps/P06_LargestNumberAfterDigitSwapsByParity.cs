// Largest Number After Digit Swaps by Parity
// ==========================================
//
// You are given a positive integer `num`. You can swap any two digits of `num` as long as they share the same parity
// (both are odd or both are even).
//
// Your task is to return the largest possible value of `num` after performing any number of such swaps.
//
// Constraints:
//
// - 1 ≤ `num` ≤ 10^9

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P06_LargestNumberAfterDigitSwapsByParity;

public class Solution
{
    // Time complexity: O(d*logd) where d=digits, Space complexity: O(d).
    public static int LargestInteger(int num)
    {
        var oddQueue = new PriorityQueue<int, int>();
        var evenQueue = new PriorityQueue<int, int>();

        for (int num2 = num; num2 != 0; num2 /= 10)
        {
            int digit = num2 % 10;
            if (digit % 2 == 0) { evenQueue.Enqueue(digit, digit); }
            else { oddQueue.Enqueue(digit, digit); }
        }

        int result = 0;
        int times = 1;
        for (int num2 = num; num2 != 0; num2 /= 10)
        {
            int digit = num2 % 10;
            if (digit % 2 == 0) { result += evenQueue.Dequeue() * times; }
            else { result += oddQueue.Dequeue() * times; }

            times *= 10;
        }

        return result;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(1, 1);
        Run(12341234, 34341212);
    }

    private static void Run(int num, int expectedResult)
    {
        int result = Solution.LargestInteger(num);
        Utilities.PrintSolution(num, result);
        Assert.AreEqual(expectedResult, result);
    }
}
