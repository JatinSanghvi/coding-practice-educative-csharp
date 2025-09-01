// Daily Temperatures
// ==================
//
// Given an array of integers, `temperatures`, that represents daily temperatures, return an array, `output`, where each
// element, `output[i]`, indicates the number of days you need to wait after the i-th day to experience a warmer
// temperature; if there is no future day with a higher temperature, set `output[i]` to 0.
//
// Constraints:
//
// - 1 ≤ `temperatures.length` ≤ 10^3
// - 30 ≤ `temperatures[i]` ≤ 100

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N19_Stacks.P07_DailyTemperatures;

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
