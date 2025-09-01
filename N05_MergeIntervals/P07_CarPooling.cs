// Car Pooling
// ===========
//
// You are given a car with a fixed number of seats, denoted by an integer `capacity`. The car only travels in one
// direction --- eastward --- and does not make any U-turns.
//
// You are also provided with an array, `trips`, where each element `trips[i] = [numPassengers_i, from_i, to_i]`
// represents a group of `numPassengers_i` that must be picked up at location `from_i` and dropped off at location
// `to_i`. All locations are measured in kilometers east of the starting point.
//
// Your task is to determine whether it is possible to complete all the trips without exceeding the car's capacity at
// any point in time.
//
// Return TRUE if all trips can be completed successfully, or FALSE otherwise.
//
// Constraints:
//
// - 1 ≤ trips.length ≤ 1000
// - trips[i].length == 3
// - 1 ≤ numPassengers_i ≤ 100
// - 0 ≤ from_i < to_i ≤ 1000
// - 1 ≤ capacity ≤ 10^5

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N05_MergeIntervals.P07_CarPooling;

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
