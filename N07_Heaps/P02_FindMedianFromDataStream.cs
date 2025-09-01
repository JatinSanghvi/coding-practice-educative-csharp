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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P02_FindMedianFromDataStream;

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
