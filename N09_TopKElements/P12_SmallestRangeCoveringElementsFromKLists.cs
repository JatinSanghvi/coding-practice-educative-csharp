// Smallest Range Covering Elements from K Lists
// =============================================
//
// You are given k sorted lists of integers, `nums`, where each list in `nums` is in non-decreasing order. Your task is
// to find the smallest range that contains at least one element from each of the k lists.
//
// A range [a, b] is considered smaller than another range [c, d] if b - a < d - c, or a < c if b - a == d - c.
//
// Constraints:
//
// - `nums.length` == k
// - 1 ≤ k ≤ 100
// - 1 ≤ `nums[i].length` ≤ 50
// - -10^3 ≤ `nums[i][j]` ≤ 10^3
// - `nums[i]` is sorted in a non-decreasing order.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P12_SmallestRangeCoveringElementsFromKLists;

public class Solution
{
    // Time complexity: O(n*logk), Space complexity: O(k).
    public int[] SmallestRange(List<List<int>> nums)
    {
        var numsQueue = new PriorityQueue<(int i1, int i2), int>();

        int max = int.MinValue;
        for (int i1 = 0; i1 < nums.Count; i1++)
        {
            int num = nums[i1][0];
            numsQueue.Enqueue((i1, 0), num);
            max = Math.Max(max, num);
        }

        int rangeMin = -1000; // Setting to int.MinValue will cause integer overflow when computing max - min.
        int rangeMax = max;

        while (true)
        {
            (int i1, int i2) = numsQueue.Dequeue();

            int min = nums[i1][i2];
            if (max - min < rangeMax - rangeMin)
            {
                (rangeMin, rangeMax) = (min, max);
            }

            if (i2 == nums[i1].Count - 1)
            {
                return new int[] { rangeMin, rangeMax };
            }

            int nextNum = nums[i1][i2 + 1];
            numsQueue.Enqueue((i1, i2 + 1), nextNum);
            max = Math.Max(max, nextNum);
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 4, 7], [3, 6], [6, 8, 10]], [6, 7]);
    }

    private static void Run(int[][] numsArray, int[] expectedResult)
    {
        List<List<int>> nums = numsArray.Select(nums => nums.ToList()).ToList();
        int[] result = new Solution().SmallestRange(nums);
        Utilities.PrintSolution(numsArray, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
