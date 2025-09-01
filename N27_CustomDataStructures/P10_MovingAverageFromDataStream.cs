// Moving Average from Data Stream
// ===============================
//
// Given a stream of integers and a window size, calculate the moving average of all integers in the sliding window.
// Implement a class called `MovingAverage` that has the following methods:
//
// - Constructor (int size): This constructor initializes the object with the specified window size.
//
// - double next (int val): This method takes an integer value as input and returns the moving average of the last
//   `size` values from the stream.
//
// Constraints:
//
// - 1 ≤ `size` ≤ 100
// - -10^3 ≤ `val` ≤ 10^3
// - At most 10^2 calls can be made to next.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P10_MovingAverageFromDataStream;

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
