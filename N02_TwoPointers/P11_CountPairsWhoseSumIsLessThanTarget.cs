// Count Pairs Whose Sum is Less than Target
// =========================================
//
// You are given a 0-indexed integer array, `nums`, of length n, and an integer `target`. Your task is to determine the
// number of distinct pairs of indexes (i,j) such that:
//
// - 0 ≤ i < j < n (i.e., i comes before j in the array)
// - The sum of the elements of the indexes (i,j), (i.e., nums[i]+nums[j]), is strictly less than the `target`.
//
// Constraints:
//
// - n = `nums.length`
// - 1 ≤ n ≤ 50
// - -50 ≤ `nums[i]`, `target` ≤ 50

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N02_TwoPointers.P11_CountPairsWhoseSumIsLessThanTarget;

public class Solution
{
    public static int CountPairs(IList<int> nums, int target)
    {
        int count = 0;
        int[] numsArray = nums.Order().ToArray();

        for (int left = 0, right = numsArray.Length - 1; left < right;)
        {
            if (numsArray[left] + numsArray[right] < target)
            {
                // numsArray[left] + { numsArray[left + 1] .. numsArray[right] }.
                count += right - left;
                left++;
            }
            else
            {
                right--;
            }
        }

        return count;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([0, 10, 20, 30, -10, -20], 30, 11);
        Run([10, 10, 20, 20], 30, 1);
    }

    private static void Run(List<int> nums, int target, int expectedCount)
    {
        int count = Solution.CountPairs(nums, target);
        Utilities.PrintSolution((nums, target), count);
        Assert.AreEqual(expectedCount, count);
    }
}
