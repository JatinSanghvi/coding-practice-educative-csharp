// Single Number II
// ================
//
// Given a non-empty array `arr`, in which exactly two elements appear once, and all the other elements appear twice,
// return the two elements that appeared only once.
//
// > Note: The result can be returned in any order. The solution should use only constant extra space.
//
// Constraints:
//
// - 2 ≤ `arr.length` ≤ 10^3
// - -2^31 ≤ `arr[i]` ≤ 2^31 - 1

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P05_SingleNumberII;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int[] TwoSingleNumbers(int[] arr)
    {
        int xor = 0;

        foreach (int num in arr)
        {
            xor ^= num;
        }

        int mask = xor & -xor; // Has a single bit set that differs between the two single-numbers.

        int num1 = 0, num2 = 0;

        foreach (int num in arr)
        {
            if ((num & mask) == 0) { num1 ^= num; }
            else { num2 ^= num; }
        }

        return [num1, num2];
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3, 1], [2, 3]);
    }

    private static void Run(int[] arr, int[] expectedResult)
    {
        int[] result = Solution.TwoSingleNumbers(arr);
        Utilities.PrintSolution(arr, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
