// Kth Largest Element in an Array
// ===============================
//
// Find the kth largest element in an unsorted array.
//
// > Note: We need to find the kth largest element in the sorted order, not the kth distinct element.
//
// Constraints:
//
// - 1 ≤ k ≤ `nums.length` ≤ 10^3
// - -10^4 ≤ `nums[i]` ≤ 10^4

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P05_KthLargestElementInAnArray;

public class Solution
{
    // Time complexity: O(n*logk), Space complexity: O(k).
    public static int FindKthLargest(int[] nums, int k)
    {
        var numQueue = new PriorityQueue<int, int>();

        foreach (int num in nums)
        {
            numQueue.Enqueue(num, num);
            if (numQueue.Count > k)
            {
                numQueue.Dequeue();
            }
        }

        return numQueue.Peek();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3, 1, 3], 3, 2);
    }

    private static void Run(int[] nums, int k, int expectedResult)
    {
        int result = Solution.FindKthLargest(nums, k);
        Utilities.PrintSolution((nums, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
