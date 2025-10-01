// Boats to Save People
// ====================
//
// A big ship with numerous passengers is sinking, and there is a need to evacuate these people with the minimum number
// of life-saving boats. Each boat can carry, at most, two persons; however, the weight of the people cannot exceed the
// carrying weight limit of the boat.
//
// We are given an array, `people`, where `people[i]` is the weight of the i-th person, and an infinite number of boats,
// where each boat can carry a maximum weight, `limit`. Each boat carries, at most, two people at the same time. This is
// provided that the sum of the weight of these people is under or equal to the weight limit.
//
// You need to return the minimum number of boats to carry all persons in the array.
//
// Constraints:
//
// - 1 ≤ `people.length` ≤ 5 × 10^3
// - 1 ≤ `people[i]` ≤ `limit` ≤ 3 × 10^3

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P02_BoatsToSavePeople;

public class Solution
{
    // Time complexity: O(n*logn), Space complexity: O(1).
    public static int RescueBoats(int[] people, int limit)
    {
        Array.Sort(people);
        int light = 0, heavy = people.Length - 1;
        int boats = 0;
        while (light <= heavy)
        {
            if (light != heavy && people[light] + people[heavy] <= limit)
            {
                light++;
            }

            heavy--;
            boats++;
        }

        return boats;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([4, 3, 2, 1], 4, 3);
        Run([4, 3, 2, 1], 5, 2);
    }

    private static void Run(int[] people, int limit, int expectedResult)
    {
        int[] peopleCopy = people.ToArray();
        int result = Solution.RescueBoats(people, limit);
        Utilities.PrintSolution((peopleCopy, limit), result);
        Assert.AreEqual(expectedResult, result);
    }
}
