// Maximal Score After Applying K Operations
// =========================================
//
// You are given a 0-indexed array of integer `nums` and an integer `k`. Your task is to maximize a score through a
// series of operations. Initially, your score is set to 0.
//
// In each operation:
//
// 1. Select an index `i` (where 0 ≤ i < `nums.length`).
// 2. Add the value of `nums[i]` to your score.
// 3. Replace `nums[i]` with `ceil(nums[i] / 3)`.
//
// Repeat this process exactly `k` times and return the highest score you can achieve.
//
// > The ceiling function `ceil(value)` is the least integer greater than or equal to `value`.
//
// Constraints:
//
// - 1 ≤ `nums.length`, k ≤ 10^3
// - 1 ≤ `nums[i]` ≤ 10^5

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P09_MaximalScoreAfterApplyingKOperations;

public class Solution
{
    // Time complexity: O(k*logn), Space complexity: O(n).
    public static int MaxScore(int[] nums, int target)
    {
        var scores = new PriorityQueue<int, int>(nums.Select(n => (n, -n)));

        int maxScore = 0;
        for (int i = 0; i < target; i++)
        {
            int score = scores.Dequeue();
            maxScore += score;
            int newScore = (score + 2) / 3;
            scores.Enqueue(newScore, -newScore);
        }

        return maxScore;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3, 10, 11, 12], 1, 12);
        Run([1, 2, 3, 10, 11, 12], 9, 52);
    }

    private static void Run(int[] nums, int target, int expectedResult)
    {
        int result = Solution.MaxScore(nums, target);
        Utilities.PrintSolution((nums, target), result);
        Assert.AreEqual(expectedResult, result);
    }
}
