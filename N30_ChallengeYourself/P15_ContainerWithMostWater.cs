// Container with Most Water
// =========================
//
// You're given an integer array `height` of length n, and there are n vertical lines drawn such that the two endpoints
// of the ith line are (i,0) and (i, `height[i]`).
//
// Find two lines from the input array that, together with the x-axis, form a container that holds as much water as
// possible. Return the maximum amount of water a container can store.
//
// > Note: You may not slant the container.
//
// Constraints:
//
// - n = `height.length`
// - 2 ≤ n ≤ 10^3
// - 0 ≤ `height[i]` ≤ 10^3

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P15_ContainerWithMostWater;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int MaxArea(int[] height)
    {
        int left = 0, right = height.Length - 1;
        int area = 0;

        while (left < right)
        {
            if (height[left] <= height[right])
            {
                area = Math.Max(area, (right - left) * height[left]);
                left++;
            }
            else
            {
                area = Math.Max(area, (right - left) * height[right]);
                right--;
            }
        }

        return area;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 3, 6, 6, 3, 1], 9);
    }

    private static void Run(int[] height, int expectedResult)
    {
        int result = Solution.MaxArea(height);
        Utilities.PrintSolution(height, result);
        Assert.AreEqual(expectedResult, result);
    }
}
