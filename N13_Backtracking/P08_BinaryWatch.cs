// Binary Watch
// ============
//
// A binary watch has 4 LEDs for displaying hours (ranging from 0 to 11) and 6 for displaying minutes (ranging from 0 to
// 59). Each LED can be on (1) or off (0), with the least significant bit on the right.
//
// Given an integer `enabled`, which represents the number of LEDs currently turned on, return all possible times that
// the watch could display. You may return the answer in any order.
//
// > Note: Remember the following regarding leading zeros:
//
// > - The hour cannot have a leading zero (e.g., "01:00" is invalid, it should be "1:00").
// > - The minute must be two digits and may include a leading zero (e.g., "10:2" is invalid, it should be "10:02").
//
// Constraints:
//
// - 0 ≤ `enabled` ≤ 10

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P08_BinaryWatch;

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
