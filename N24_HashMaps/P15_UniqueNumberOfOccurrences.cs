// Unique Number of Occurrences
// ============================
//
// Given an array of integers `nums`, return TRUE if each value in the array has a unique number of occurrences;
// otherwise, return FALSE.
//
// Constraints:
//
// - 1 <= `nums.length` <= 1000
// - -1000 <= `nums[i]` <= 1000

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P15_UniqueNumberOfOccurrences;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static bool UniqueOccurrences(int[] nums)
    {
        var occurrences = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            occurrences[num] = occurrences.GetValueOrDefault(num) + 1;
        }

        var knownOccurrences = new HashSet<int>();
        foreach (int occ in occurrences.Values)
        {
            if (!knownOccurrences.Add(occ))
            {
                return false;
            }
        }

        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 2, 3, 3, 3], true);
        Run([1, 2, 2, 3, 3, 4], false);
    }

    private static void Run(int[] nums, bool expectedResult)
    {
        bool result = Solution.UniqueOccurrences(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}
