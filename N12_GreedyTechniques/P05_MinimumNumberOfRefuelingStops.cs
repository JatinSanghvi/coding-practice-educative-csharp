// Minimum Number of Refueling Stops
// =================================
//
// You need to find the minimum number of refueling stops that a car needs to make to cover a distance, `target`. For
// simplicity, assume that the car has to travel from west to east in a straight line. There are various fuel stations
// on the way that are represented as a 2-D array of stations, i.e., `stations[i] = [d_i, f_i]`, where `d_i` is the
// distance (in miles) of the i-th gas station from the starting position, and `f_i` is the amount of fuel (in liters)
// that it stores. Initially, the car starts with `k` liters of fuel. The car consumes one liter of fuel for every mile
// traveled. Upon reaching a gas station, the car can stop and refuel using all the petrol stored at the station. If it
// cannot reach the target, the program returns -1.
//
// Note: If the car reaches a station with 0 fuel left, it can refuel from that station, and all the fuel from that
// station can be transferred to the car. If the car reaches the target with 0 fuel left, it is still considered to have
// arrived.
//
// Constraints:
//
// - 1 ≤ `target`, `k` ≤ 10^9
// - 0 ≤ `stations.length` ≤ 900
// - 1 ≤ `d_i` < `d_{i+1}` < `target`
// - 1 ≤ `f_i` < 10^9

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P05_MinimumNumberOfRefuelingStops;

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
