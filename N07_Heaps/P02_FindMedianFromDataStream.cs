// Find Median from Data Stream
// ============================
//
// Design a data structure that stores a dynamically changing list of integers and can find the median in constant time,
// O(1), as the list grows. To do that, implement a class named `MedianOfStream` with the following functionality:
//
// - Constructor(): Initializes an instance of the class.
// - insertNum(int num): Adds a new integer `num` to the data structure.
// - findMedian(): Returns the median of all integers added so far.
//
// Note: The median is the middle value in a sorted list of integers.
//
// - For an odd-sized list (e.g., [4,5,6]), the median is the middle element: 5.
// - For an even-sized list (e.g., [2,4,6,8]), the median is the average of the two middle elements: (4 + 6) / 2 = 5.
//
// Constraints:
//
// - -10^5 ≤ `num` ≤ 10^5, where `num` is an integer received from the data stream.
// - There will be at least one element in the data structure before the median is computed.
// - At most, 500 calls will be made to the function that calculates the median.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P02_FindMedianFromDataStream;

// Space complexity: O(n).
public class MedianOfStream
{
    private readonly PriorityQueue<int, int> lowerNums = new();
    private readonly PriorityQueue<int, int> upperNums = new();

    // Time complexity: O(logn).
    public void InsertNum(int num)
    {
        if (lowerNums.Count == 0 || num <= lowerNums.Peek())
        {
            // Enqueue before dequeue as the number, if dequeued earlier, can turn out to be smaller than the inserted
            // number.
            lowerNums.Enqueue(num, -num);
            if (lowerNums.Count == upperNums.Count + 2)
            {
                int num2 = lowerNums.Dequeue();
                upperNums.Enqueue(num2, num2);
            }
        }
        else
        {
            upperNums.Enqueue(num, num);
            if (upperNums.Count == lowerNums.Count + 1)
            {
                int num2 = upperNums.Dequeue();
                lowerNums.Enqueue(num2, -num2);
            }
        }
    }

    // Time complexity: O(1).
    public double FindMedian()
    {
        if (lowerNums.Count == upperNums.Count)
        {
            return (lowerNums.Peek() + upperNums.Peek()) / 2.0;
        }
        else
        {
            return lowerNums.Peek();
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(["Insert 1", "Find", "Insert 2", "Find", "Insert 3", "Find"], [1.0, 1.5, 2.0]);
        Run(["Insert 1", "Find", "Insert 3", "Find", "Insert 2", "Find"], [1.0, 2.0, 2.0]);
        Run(["Insert 3", "Find", "Insert 1", "Find", "Insert 2", "Find"], [3.0, 2.0, 2.0]);
    }

    private static void Run(string[] operations, double[] expectedResult)
    {
        var medianOfStream = new MedianOfStream();
        var result = new List<double>();
        foreach (string operation in operations)
        {
            if (operation.StartsWith("Insert "))
            {
                medianOfStream.InsertNum(int.Parse(operation[7..]));
            }
            else if (operation == "Find")
            {
                result.Add(medianOfStream.FindMedian());
            }
        }

        Utilities.PrintSolution(operations, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
