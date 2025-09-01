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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P11_CanPlaceFlowers;

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
