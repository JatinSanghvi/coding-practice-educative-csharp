// Bus Routes
// ==========
//
// You are given an array, `routes`, representing bus routes where `routes[i]` is a bus route that the i-th bus repeats
// forever. Every route contains one or more stations. You have also been given the source station, `src`, and a
// destination station, `dest`. Return the minimum number of buses someone must take to travel from `src` to `dest`, or
// return `-1` if there is no route.
//
// Constraints:
//
// - 1 ≤ `routes.length` ≤ 50
// - 1 ≤ `routes[i].length` ≤ 100
// - 0 ≤ `routes[i][j]` < 1000
// - 0 ≤ `src`, `dest` < 1000

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N20_Graphs.P05_BusRoutes;

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
