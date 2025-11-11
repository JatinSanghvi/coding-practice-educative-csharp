// Combination Sum
// ===============
//
// Given an array of distinct integers, `nums`, and an integer, `target`, return a list of all unique combinations of
// `nums` where the chosen numbers sum up to the `target`. The combinations may be returned in any order.
//
// An integer from `nums` may be chosen an unlimited number of times. Two combinations are unique if the frequency of at
// least one of the chosen integers is different.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 30
// - 2 ≤ `nums[i]` ≤ 40
// - 1 ≤ `target` ≤ 40
// - All integers of `nums` are unique.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P09_CombinationSum;

public class Solution
{
    public static IList<IList<int>> CombinationSum(int[] nums, int target)
    {
        var combinations = new IList<IList<int>>[target + 1];
        combinations[0] = new List<IList<int>> { new List<int>() };

        for (int i = 1; i != target + 1; i++)
        {
            combinations[i] = new List<IList<int>>();
            foreach (int num in nums)
            {
                if (i - num >= 0)
                {
                    foreach (List<int> prevCombination in combinations[i - num])
                    {
                        if (prevCombination.Count == 0 || prevCombination[^1] <= num)
                        {
                            var newCombination = prevCombination.ToList();
                            newCombination.Add(num);
                            combinations[i].Add(newCombination);
                        }
                    }
                }
            }
        }

        return combinations[target];
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([2, 3, 4], 6, [[2, 2, 2], [3, 3], [2, 4]]);
    }

    private static void Run(int[] nums, int target, int[][] expectedResult)
    {
        int[] numsCopy = nums.ToArray();

        int[][] result = Solution.CombinationSum(nums, target)
            .Select(comb => comb.ToArray())
            .ToArray();

        Utilities.PrintSolution((numsCopy, target), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
