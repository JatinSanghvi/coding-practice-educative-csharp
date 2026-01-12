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

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P10_MovingAverageFromDataStream;

// Space complexity: O(size).
public class MovingAverage(int size)
{
    private double sum = 0.0;
    private readonly Queue<int> queue = new();

    // Time complexity: O(1).
    public double Next(int val)
    {
        queue.Enqueue(val);
        sum += val;

        if (queue.Count > size)
        {
            sum -= queue.Dequeue();
        }

        return sum / queue.Count;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(4, [0, 1, 2, 3, 4, 5, 6, 7], [0.0, 0.5, 1.0, 1.5, 2.5, 3.5, 4.5, 5.5]);
    }

    private static void Run(int size, int[] vals, double[] expectedResults)
    {
        var movingAverage = new MovingAverage(size);

        for (int i = 0; i != vals.Length; i++)
        {
            double result = movingAverage.Next(vals[i]);
            Utilities.PrintSolution(vals[i], result);
            Assert.AreEqual(expectedResults[i], result);
        }
    }
}
