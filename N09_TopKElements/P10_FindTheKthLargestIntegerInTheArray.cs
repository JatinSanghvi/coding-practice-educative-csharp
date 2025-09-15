// Find the Kth Largest Integer in the Array
// =========================================
//
// Given an array of strings, `nums`, where each string represents an integer without leading zeros, and an integer `k`,
// your task is to find and return the string representing the kth largest integer in the array.
//
// > Note: Treat duplicate integers as distinct entities. For instance, if `nums` = ["2", "3", "3"], the first largest
// > integer is "3", the second largest is also "3", and the third largest is "2".
//
// Constraints:
//
// - 1 ≤ k ≤ `nums.length` ≤ 10^3
// - 1 ≤ `nums[i].length` ≤ 100
// - `nums[i]` consists of only digits.
// - `nums[i]` will not have any leading zeros.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P10_FindTheKthLargestIntegerInTheArray;

public class Solution
{
    // Time complexity: O(n*logk), Space complexity: O(n).
    public static string KthLargestInteger(string[] nums, int k)
    {
        var numComparer = Comparer<string>.Create((s1, s2) =>
        {
            if (s1.Length != s2.Length) { return s1.Length - s2.Length; }
            return s1.CompareTo(s2);
        });

        var numQueue = new PriorityQueue<string, string>(numComparer);

        foreach (string num in nums)
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
        Run(["1", "10", "11", "20", "100", "1", "10", "11", "20", "100"], 2, "100");
        Run(["1", "10", "11", "20", "100", "1", "10", "11", "20", "100"], 5, "11");
        Run(["1", "10", "11", "20", "100", "1", "10", "11", "20", "100"], 10, "1");
    }

    private static void Run(string[] nums, int k, string expectedResult)
    {
        string result = Solution.KthLargestInteger(nums, k);
        Utilities.PrintSolution((nums, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
