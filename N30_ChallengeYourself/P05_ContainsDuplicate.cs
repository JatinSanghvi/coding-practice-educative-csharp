// Contains Duplicate
// ==================
//
// For a given array of integers, `nums`, return TRUE if it contains duplicates. Otherwise, return FALSE.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^5
// - -10^9 ≤ `nums[i]` ≤ 10^9

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P05_ContainsDuplicate;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static bool ContainsDuplicate(int[] nums)
    {
        var numSet = new HashSet<int>();

        foreach (int num in nums)
        {
            if (numSet.Contains(num))
            {
                return true;
            }

            numSet.Add(num);
        }

        return false;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 4, 8, 4], true);
        Run([1, 2, 4, 8], false);
    }

    private static void Run(int[] nums, bool expectedResult)
    {
        bool result = Solution.ContainsDuplicate(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}
