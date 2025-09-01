// Nested List Weight Sum II
// =========================
//
// Given a nested list of integers, `nestedList`, where each element can either be an integer or a list, which can
// contain integers or more lists, return the sum of each integer in `nestedList` multiplied by its weight.
//
// The weight of an integer is calculated as `maxDepth` minus the depth of the integer plus one.
//
// The depth of an integer is defined as the number of nested lists it is contained within. For instance, the value of
// each integer in the list `[1,[2,2],[[3],2],1]` is equal to its depth. Let `maxDepth` represent the maximum depth of
// any integer in the `nestedList`.
//
// Constraints:
//
// - 1 ≤ `nestedList.length` ≤ 50
//
// - The values of the integers in the nested list are in the range [-100, 100]
//
// - `maxDepth` ≤ 50

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N21_TreeDepthFirstSearch.P11_NestedListWeightSumII;

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
