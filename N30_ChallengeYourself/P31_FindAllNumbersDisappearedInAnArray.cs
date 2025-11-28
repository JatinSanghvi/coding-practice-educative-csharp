// Find All Numbers Disappeared in an Array
// ========================================
//
// Given an array, `nums`, of n integers where `nums[i]` is in the range [1,n], return an array of all the integers in
// the range [1,n] that doesn't appear in `nums`.
//
// Constraints:
//
// - n = `nums.length`
// - 1 ≤ n ≤ 10^3
// - 1 ≤ `nums[i]` ≤ n

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P31_FindAllNumbersDisappearedInAnArray;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static List<int> FindDisappearedNumbers(int[] nums)
    {
        for (int i = 0; i != nums.Length; i++)
        {
            while (nums[i] != i + 1)
            {
                int j = nums[i] - 1;
                if (nums[i] == nums[j]) { break; }
                nums[i] = nums[j];
                nums[j] = j + 1;
            }
        }

        var disappeared = new List<int>();
        for (int i = 0; i != nums.Length; i++)
        {
            if (nums[i] != i + 1)
            {
                disappeared.Add(i + 1);
            }
        }

        return disappeared;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3, 4], []);
        Run([2, 2, 1, 1], [3, 4]);
        Run([4, 3, 3, 4], [1, 2]);
    }

    private static void Run(int[] nums, int[] expectedResult)
    {
        int[] result = Solution.FindDisappearedNumbers(nums).ToArray();
        Utilities.PrintSolution(nums, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
