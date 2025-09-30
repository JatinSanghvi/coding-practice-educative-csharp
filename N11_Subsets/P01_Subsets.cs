// Subsets
// =======
//
// Given an array of integers, `nums`, find all possible subsets of `nums`, including the empty set.
//
// > Note: The solution set must not contain duplicate subsets. You can return the solution in any order.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10
// - -10 ≤ `nums[i]` ≤ 10
// - All the numbers of `nums` are unique.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N11_Subsets.P01_Subsets;

public class Solution
{
    // Time complexity: O(n*2^n), Space complexity: O(1).
    public static IList<IList<int>> FindAllSubsets(int[] nums)
    {
        int count = 1 << nums.Length;
        var subsets = new List<IList<int>>(count);

        for (int subsetNum = 0; subsetNum != count; subsetNum++)
        {
            var subset = new List<int>();
            for (int index = 0; index != nums.Length; index++)
            {
                if ((subsetNum & (1 << index)) != 0)
                {
                    subset.Add(nums[index]);
                }
            }

            subsets.Add(subset);
        }

        return subsets;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([4, 5, 6], [[], [4], [5], [4, 5], [6], [4, 6], [5, 6], [4, 5, 6]]);
    }

    private static void Run(int[] nums, int[][] expectedResult)
    {
        int[][] result = Solution.FindAllSubsets(nums)
            .Select(subset => subset.ToArray())
            .ToArray();

        Utilities.PrintSolution(nums, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
