// Kth Largest Element in a Stream
// ===============================
//
// Given an infinite stream of integers (sorted or unsorted), `nums`, design a class to find the k-th largest element in
// a stream.
//
// > Note: It is the kth largest element in the sorted order, not the kth distinct element.
//
// The class should have the following functions, inputs, and return values:
//
// - Init(nums, k): It takes an array of integers `nums` and an integer `k` and initializes the class object.
// - Add(value): It takes one integer `value`, appends it to the stream, and returns the element representing the k-th
//   largest element in the stream.
//
// Constraints:
//
// - 1 ≤ k ≤ 10^3
// - 0 ≤ `nums.length` ≤ 10^3
// - -10^3 ≤ `nums[i]` ≤ 10^3
// - -10^3 ≤ `value` ≤ 10^3
// - At most, 10^3 calls will be made to add.
// - It is guaranteed that there will be at least k elements in the array when you search for the kth element.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P01_KthLargestElementInAStream;

public class KthLargest
{
    private readonly PriorityQueue<int, int> _largestNums = new();

    // Time complexity: O(n*logk), Space complexity: O(k).
    public KthLargest(int k, int[] nums)
    {
        foreach (int num in nums)
        {
            _largestNums.Enqueue(num, num);
            if (_largestNums.Count > k)
            {
                _largestNums.Dequeue();
            }
        }
    }

    // Time complexity: O(logk).
    public int Add(int val)
    {
        _largestNums.EnqueueDequeue(val, val);
        return _largestNums.Peek();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(3, [2, 6, 4, 8], [5, 9, 7], [5, 6, 7]);
    }

    private static void Run(int k, int[] nums, int[] adds, int[] expectedResult)
    {
        var kthLargest = new KthLargest(k, nums);
        int[] result = adds.Select(kthLargest.Add).ToArray();
        Utilities.PrintSolution((k, nums, adds), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
