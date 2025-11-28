// 4Sum
// ====
//
// Given an array `nums` of n integers, return an array of all the unique quadruplets, [`nums[a]`, `nums[b]`, `nums[c]`,
// `nums[d]`] such that:
//
// - 0 ≤ `a`, `b`, `c`, `d` < n
// - `a`, `b`, `c`, and `d` are distinct.
// - `nums[a]` + `nums[b]` + `nums[c]` + `nums[d]` = `target`
//
// You may return the answer in any order.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 200
// - -10^9 ≤ `nums[i]` ≤ 10^9
// - -10^9 ≤ `target` ≤ 10^9

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P17_4Sum;

public class Solution
{
    // Time complexity: O(n^2 log(n^2)), Space complexity: O(n^2).
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        // Construct dictionary with two-sums as keys and list of index-pairs as values.
        var twoSums = new SortedDictionary<int, List<(int, int)>>();

        for (int i = 0; i != nums.Length; i++)
        {
            for (int j = i + 1; j != nums.Length; j++)
            {
                int sum = nums[i] + nums[j];
                if (!twoSums.ContainsKey(sum))
                {
                    twoSums[sum] = new List<(int, int)>();
                }

                twoSums[sum].Add((i, j));
            }
        }

        KeyValuePair<int, List<(int, int)>>[] twoSumPairs = twoSums.ToArray();
        var fourSums = new HashSet<(int, int, int, int)>();

        int low = 0, high = twoSums.Count - 1;
        while (low <= high) // <= ensures that indexes within same list are considered if key = target / 2.
        {
            int sum = twoSumPairs[low].Key + twoSumPairs[high].Key;

            if (sum < target) { low++; }
            else if (sum > target) { high--; }
            else
            {
                foreach ((int a, int b) in twoSumPairs[low].Value)
                {
                    foreach ((int c, int d) in twoSumPairs[high].Value)
                    {
                        if (a != c && a != d && b != c && b != d) // Remove duplicate index pairs.
                        {
                            var fourSum = new int[] { nums[a], nums[b], nums[c], nums[d] };
                            Array.Sort(fourSum);
                            fourSums.Add((fourSum[0], fourSum[1], fourSum[2], fourSum[3]));
                        }
                    }
                }

                low++;
                high--;
            }
        }

        return fourSums
            .Select(fourSum => new List<int> { fourSum.Item1, fourSum.Item2, fourSum.Item3, fourSum.Item4 })
            .Cast<IList<int>>()
            .ToList();
    }
}

internal static class Tests
{
    public static void Run()
    {
        // Run([-1, -1, 0, 0, 0, 0, 1, 1], 0, [[-1, -1, 1, 1], [-1, 0, 0, 1], [0, 0, 0, 0]]);
        // Run([1, 0, -1, 0], 0, [[-1, 0, 0, 1]]);
        Run([-1, -2, -3, -4, -5], -10, [[-4, -3, -2, -1]]);
    }

    private static void Run(int[] nums, int target, int[][] expectedResult)
    {
        int[][] result = new Solution().FourSum(nums, target).Select(pair => pair.ToArray()).ToArray();
        Utilities.PrintSolution((nums, target), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
