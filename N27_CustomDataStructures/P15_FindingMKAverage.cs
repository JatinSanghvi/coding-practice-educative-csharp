// Finding MK Average
// ==================
//
// You are given two integers, `m` and `k`, and a stream of integers. Your task is to design and implement a data
// structure that efficiently calculates the MK Average for the stream.
//
// To compute the MK Average, follow these steps:
//
// 1. Stream length check: If the stream contains fewer than `m` elements, return `-1` as the MK Average.
//
// 2. Window selection: Otherwise, copy the last `m` elements of the stream to a separate container and remove the
//    smallest `k` elements and the largest `k` elements from the container.
//
// 3. Average calculation: Calculate the average of the remaining elements (rounded down to the nearest integer).
//
// Implement the `MKAverage` class
//
// - `MKAverage(int m, int k)`: Initializes the object with integers `m` and `k` and an empty stream.
//
// - `void addElement(int num)`: Adds the integer `num` to the stream.
//
// - `int calculateMKAverage()`: Returns the current MK Average for the stream as described above, or `-1` if the stream
//   contains fewer than `m` elements.
//
// Constraints:
//
// - 3 ≤ `m` ≤ 10^5
// - 1 < `k * 2` < m
// - 1 ≤ `num` ≤ 10^5
// - 10^3 calls will be made to `addElement` and `calculateMKAverage`, at most.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P15_FindingMKAverage;

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
