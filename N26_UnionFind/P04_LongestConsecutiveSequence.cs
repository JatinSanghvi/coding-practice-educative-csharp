// Longest Consecutive Sequence
// ============================
//
// Given an unsorted array, `nums`, your task is to return the length of the longest consecutive sequence of elements.
// The consecutive sequence of elements is such that there are no missing elements in the sequence. The consecutive
// elements can be present anywhere in the input array.
//
// > Note: Two elements, x and y, are called consecutive if the difference between them is equal to 1.
//
// Constraints:
//
// - 0 ≤ `nums.lengths` ≤ 10^3
// - -10^6 ≤ `nums[i]` ≤ 10^6

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N26_UnionFind.P04_LongestConsecutiveSequence;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static int LongestConsecutiveSequence(int[] nums)
    {
        var parents = new Dictionary<int, int>();
        var sizes = new Dictionary<int, int>();
        int longestSize = 0;

        foreach (int num in nums)
        {
            parents.TryAdd(num, num);
            parents.TryAdd(num + 1, num + 1);

            sizes.TryAdd(num, 0);
            sizes.TryAdd(num + 1, 0);

            Union(num, num + 1);
        }

        return longestSize;

        void Union(int x1, int x2)
        {
            int p1 = Find(x1);
            int p2 = Find(x2);

            if (p1 != p2)
            {
                if (sizes[p1] < sizes[p2]) { (p1, p2) = (p2, p1); }

                parents[p2] = p1;
                sizes[p1] += sizes[p2] + 1;
                longestSize = Math.Max(longestSize, sizes[p1]);
            }
        }

        int Find(int x)
        {
            if (parents[x] != x) { parents[x] = Find(parents[x]); }
            return parents[x];
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([15, 5, 3, 13, 4, 2, 12], 4);
    }

    private static void Run(int[] nums, int expectedResult)
    {
        int result = Solution.LongestConsecutiveSequence(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}
