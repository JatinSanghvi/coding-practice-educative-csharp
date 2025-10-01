// Can Place Flowers
// =================
//
// Given an integer list `flowerbed`, each element is either 0 (indicating an empty plot) or 1 (indicating a planted
// plot), and an integer `n`. Determine if `n` new flowers can be planted without violating the rule that no two flowers
// can be planted in adjacent plots. Return TRUE if it's possible to plant all `n` flowers. Otherwise, return FALSE.
//
// Constraints:
//
// - 1 ≤ `flowerbed.length` ≤ 10^3
// - 0 ≤ `n` ≤ `flowerbed.length`
// - `flowerbed[i]` is 0 or 1.
// - There are no two adjacent flowers in the `flowerbed`.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P11_CanPlaceFlowers;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        int lastPosition = -2;
        int flowers = 0;
        for (int i = 0; flowers < n && i != flowerbed.Length; i++)
        {
            if (flowerbed[i] == 1)
            {
                flowers += Math.Max(0, (i - lastPosition) / 2 - 1);
                lastPosition = i;
            }
        }

        if (flowers >= n) { return true; }

        // We reached the end of flower bed. Add flowers if there's space on the far right.
        flowers += Math.Max(0, (flowerbed.Length + 1 - lastPosition) / 2 - 1);
        return flowers >= n;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([0, 0, 1, 0, 0], 2, true);
        Run([0, 0, 1, 0, 0], 3, false);
    }

    private static void Run(int[] flowerbed, int n, bool expectedResult)
    {
        bool result = new Solution().CanPlaceFlowers(flowerbed, n);
        Utilities.PrintSolution((flowerbed, n), result);
        Assert.AreEqual(expectedResult, result);
    }
}
