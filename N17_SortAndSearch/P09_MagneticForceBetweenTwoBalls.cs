// Magnetic Force Between Two Balls
// ================================
//
// In the universe Earth C-137, Rick has discovered a unique type of magnetic force between two balls when placed in his
// newly invented baskets. He has n baskets, each located at specific positions given by the array `position[i]`. Morty
// has `m` balls and needs to distribute these balls across the baskets in such a way that the minimum magnetic force
// between any two balls is *as large as possible*.
//
// > The magnetic force between two balls placed at positions x and y is calculated as the absolute difference ∣x - y∣.
//
// Given an integer array `position` and the number of balls `m`, return the maximum possible value of the minimum
// magnetic force between any two balls after they have been placed in the baskets.
//
// Constraints:
//
// - 2 ≤ `position.length` ≤ 10^3
// - 1 ≤ `position[i]` ≤ 10^4
// - All integers in `position` are unique.
// - 2 ≤ `m` ≤ `position.length`

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N17_SortAndSearch.P09_MagneticForceBetweenTwoBalls;

public class Solution
{
    public static bool Function()
    {
        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(true);
    }

    private static void Run(bool expectedResult)
    {
        bool result = Solution.Function();
        Utilities.PrintSolution(true, result);
        Assert.AreEqual(expectedResult, result);
    }
}
