// Diet Plan Performance
// =====================
//
// A dieter consumes `calories[i]` calories on the `i-th` day.
//
// Given an integer `k`, the dieter reviews their calorie intake over every sequence of `k` consecutive days (from
// `calories[i]` to `calories[i+k-1]` for all `0 <= i <= n-k`). For each sequence, they calculate `T`, the total
// calories consumed over those `k` days:
//
// - If `T` is less than `lower`, the dieter performs poorly and loses 1 point.
// - If `T` is greater than `upper`, the dieter performs better and gains 1 point.
// - If `T` is between `lower` and `upper` (inclusive), the dieter's performance is normal, and their points remain
//   the same.
//
// The dieter starts with zero points. Return the total points after the dieter follows this routine for all
// `calories.length` days. The total points can be negative.
//
// Constraints
//
// - 1 ≤ `k` ≤ `calories.length` ≤ 10^5
// - 0 ≤ `calories[i]` ≤ 20000
// - 0 ≤ `lower` ≤ `upper`

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P09_DietPlanPerformance;

public class Solution
{
    public static int dietPlanPerformance(List<int> calories, int k, int lower, int upper)
    {
        int points = 0;
        int sum = 0;
        for (int day = 0; day < calories.Count; day++)
        {
            sum += calories[day];

            if (day >= k - 1)
            {
                if (sum < lower) { points--; }
                else if (sum > upper) { points++; }

                sum -= calories[day - (k - 1)];
            }
        }

        return points;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(new List<int> { 1, 2, 3, 2, 1 }, 2, 3, 4, 2);
        Run(new List<int> { 1, 2, 3, 2, 1 }, 2, 4, 5, -2);
    }

    private static void Run(List<int> calories, int k, int lower, int upper, int expectedResult)
    {
        int result = Solution.dietPlanPerformance(calories, k, lower, upper);
        Utilities.PrintSolution((calories, k, lower, upper), result);
        Assert.AreEqual(expectedResult, result);
    }
}
