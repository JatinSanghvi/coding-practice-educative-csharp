// Gas Station
// ===========
//
// There are n gas stations along a circular route, where the amount of gas at the i-th station is `gas[i]`.
//
// We have a car with an unlimited gas tank, and it costs `cost[i]` of gas to travel from the i-th station to the next
// (i+1)-th station. We begin the journey with an empty tank at one of the gas stations.
//
// Find the index of the gas station in the integer array `gas` such that if we start from that index we may return to
// the same index by traversing through all the elements, collecting `gas[i]` and consuming `cost[i]`.
//
// - If it is not possible, return -1.
// - If there exists such index, it is guaranteed to be unique.
//
// Constraints:
//
// - `gas.length` == `cost.length`
// - 1 ≤ `gas.length`, `cost.length` ≤ 10^3
// - 0 ≤ `gas[i]`, `cost[i]` ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P03_GasStation;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int GasStationJourney(int[] gas, int[] cost)
    {
        int currentGas = 0;
        int totalGas = 0;
        int start = 0;

        for (int i = 0; i < gas.Length; i++)
        {
            if (currentGas < 0)
            {
                currentGas = 0;
                start = i;
            }

            currentGas += gas[i] - cost[i];
            totalGas += gas[i] - cost[i];
        }

        return totalGas < 0 ? -1 : start;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3, 4], [1, 4, 2, 3], 2);
        Run([1, 2, 3, 4], [1, 4, 2, 4], -1);
    }

    private static void Run(int[] gas, int[] cost, int expectedResult)
    {
        int result = Solution.GasStationJourney(gas, cost);
        Utilities.PrintSolution((gas, cost), result);
        Assert.AreEqual(expectedResult, result);
    }
}
