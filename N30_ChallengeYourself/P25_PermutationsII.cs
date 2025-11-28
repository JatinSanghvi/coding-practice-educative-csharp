// Permutations II
// ===============
//
// For a given integer list, `nums`, which might contain duplicates, return all possible unique permutations derived
// from `nums`.
//
// > Note: The order in which the permutations appear doesn't matter.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 8
// - -10 ≤ `nums[i]` ≤ 10

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P25_PermutationsII;

public class Solution
{
    // Time complexity: O(n*n!), Space complexity: O(1).
    public static IList<IList<int>> printUniquePermutations(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<IList<int>> { nums.ToList() };

        while (true)
        {
            int i;
            for (i = nums.Length - 2; i != -1 && nums[i] >= nums[i + 1]; i--) ;
            if (i == -1) { break; }

            int j;
            for (j = nums.Length - 1; nums[j] <= nums[i]; j--) ;

            (nums[i], nums[j]) = (nums[j], nums[i]); // Swap

            for (int left = i + 1, right = nums.Length - 1; left < right; left++, right--)
            {
                (nums[left], nums[right]) = (nums[right], nums[left]); // Reverse
            }

            result.Add(nums.ToList());
        }

        return result;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([2, 1, 1], [[1, 1, 2], [1, 2, 1], [2, 1, 1]]);
    }

    private static void Run(int[] nums, int[][] expectedResult)
    {
        int[] numsCopy = nums.ToArray();
        int[][] result = Solution.printUniquePermutations(nums).Select(perm => perm.ToArray()).ToArray();
        Utilities.PrintSolution(numsCopy, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
