// Minimum Space Wasted from Packaging
// ===================================
//
// You have `n` packages that need to be placed into boxes, with one package per box. There are `m` suppliers, and each
// supplier offers boxes of different sizes (with an infinite supply of each size). A package can only fit into a box if
// the size of the box is greater than or equal to the size of the package.
//
// The sizes of the packages and boxes are provided as follows:
//
// - The sizes of the packages are given as an integer array, `packages`, where `packages[i]` represents the size of the
//   i-th package.
// - The sizes of the boxes offered by the j-th supplier are given in a 2D array, `boxes`, where `boxes[j]` is an array
//   of distinct box sizes provided by that supplier.
//
// You want to choose a single supplier and use boxes from them to minimize wasted space. The wasted space for a package
// is calculated as the difference between the box and package sizes. The total wasted space is the sum of the wasted
// space for all the packages.
//
// Return the minimum wasted space by selecting the supplier whose boxes result in the least waste, or return -1 if it
// is impossible to fit all the packages using any supplier's boxes. As the result can be large, return it modulo 10^9 +
// 7.
//
// Constraints:
//
// - n == `packages.length`, m == `boxes.length`
// - 1 ≤ `n`, `m` ≤ 50
// - 1 ≤ `packages[i]` ≤ 10^3
// - 1 ≤ `boxes[j].length` ≤ 30
// - sum(boxes[j].length) ≤ 10^5
// - 1 ≤ `boxes[j][k]` ≤ 10^3
// - The elements in `boxes[j]` are distinct.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N17_SortAndSearch.P11_MinimumSpaceWastedFromPackaging;

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
