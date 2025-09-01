// 3Sum
// ====
//
// Given an integer array, `nums`, find and return all unique triplets `[nums[i], nums[j], nums[k]]`, such that
// `i` ≠ `j`, `i` ≠ `k`, and `j` ≠ `k` and `nums[i] + nums[j] + nums[k]` == 0.
//
// > Note: The order of the triplets in the output *does not* matter.
//
// Constraints:
//
// - 3 ≤ `nums.length` ≤ 500
// - -10^3 ≤ `nums[i]` ≤ 10^3

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N02_TwoPointers.P02_3Sum;

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var triplets = new List<IList<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (i != 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            int j = i + 1;
            int k = nums.Length - 1;

            while (j < k)
            {
                if (j != i + 1 && nums[j] == nums[j - 1])
                {
                    j++;
                    continue;
                }

                if (k != nums.Length - 1 && nums[k] == nums[k + 1])
                {
                    k--;
                    continue;
                }

                int sum = nums[i] + nums[j] + nums[k];

                if (sum < 0)
                {
                    j++;
                }
                else if (sum > 0)
                {
                    k--;
                }
                else
                {
                    triplets.Add(new List<int> { nums[i], nums[j], nums[k] });
                    j++;
                    k--;
                }
            }
        }

        return triplets;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(
            nums: new[] { -2, 0, 2, -2, 1, -1 },
            expectedResult: new List<IList<int>>
            {
                new List<int> { -2, 0, 2 },
                new List<int> { -1, 0, 1 },
            });
    }

    private static void Run(int[] nums, IList<IList<int>> expectedResult)
    {
        IList<IList<int>> result = new Solution().ThreeSum(nums);
        Utilities.PrintSolution(nums, result);

        Assert.AreEqual(expectedResult.Count, result.Count);
        for (int i = 0; i < result.Count; i++)
        {
            CollectionAssert.AreEqual(expectedResult[i].ToArray(), result[i].ToArray());
        }
    }
}
