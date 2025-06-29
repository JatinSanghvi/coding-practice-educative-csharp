// You are given a 0-indexed integer array, `nums`, of length n, and an integer `target`. Your task is to determine the
// number of distinct pairs of indexes (i,j) such that:
// 
// - 0 ≤ i < j < n (i.e., i comes before j in the array)
// - The sum of the elements of the indexes (i,j), (i.e., nums[i]+nums[j]), is strictly less than the `target`.
// 
// Constraints:
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
        int[] numsArray = nums.Order().ToArray();

        int count = 0;
        for (int i = 0, j = numsArray.Length - 1; i < j;)
        {
            if (numsArray[i] + numsArray[j] >= target)
            {
                j -= 1;
            }
            else
            {
                count += j - i;
                i += 1;
            }
        }

        return count;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Assert.AreEqual(11, Solution.CountPairs([0, 10, 20, 30, -10, -20], 30));
        Assert.AreEqual(1, Solution.CountPairs([10, 10, 20, 20], 30));
    }
}
