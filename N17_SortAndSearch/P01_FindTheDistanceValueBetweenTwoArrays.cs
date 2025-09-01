// Find the Distance Value Between Two Arrays
// ==========================================
//
// You are given two integer arrays, `arr1` and `arr2`, along with an integer `d`. Your task is to find and return the
// distance value between these arrays.
//
// > Note: The distance value is defined as the count of elements in `arr1` for which there is no element in `arr2` such
// > that ∣arr1[i] - arr2[j]∣ ≤ `d`.
//
// Constraints:
//
// - 1 ≤ `arr1.length`, `arr2.length` ≤ 500
// - -1000 ≤ `arr1[i]`, `arr2[j]` ≤ 1000
// - 0 ≤ `d` ≤ 100

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N17_SortAndSearch.P01_FindTheDistanceValueBetweenTwoArrays;

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
