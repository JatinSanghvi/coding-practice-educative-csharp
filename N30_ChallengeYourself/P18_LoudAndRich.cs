// Loud and Rich
// =============
//
// You're given a group of individuals where everyone has a specific amount of money and a different level of quietness.
// Additionally, you're given an array `richer` = [x_i,y_i], so that x_i has more money than y_i. The quietness level of
// each individual is represented using an array named `quiet`.
//
// Return an integer array `res`, where `res[i]` = `y`. If `y` has the lowest value in `quiet[y]` among all individuals,
// who have equal or more money than the individual `i`.
//
// Constraints:
//
// - n = `quiet.length`
// - 1 ≤ n ≤ 500
// - 0 ≤ `quiet[i]` < n
// - All the values of `quiet` are unique.
// - 0 ≤ `richer.length` ≤ n ∗ (n - 1) / 2
// - 0 ≤ `x[i]`, `y[i]` < `n`
// - x_i ≠ y_i
// - All the pairs of `richer` are unique.
// - The observations in `richer` are all logically consistent.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P18_LoudAndRich;

public class Solution
{
    // Time complexity: O(m + n), Space complexity: O(m + n).
    public static int[] LoudAndRich(int[][] richer, int[] quiet)
    {
        int count = quiet.Length;
        var poorerList = new List<int>[count];
        var richerCount = new int[count];

        for (int person = 0; person != count; person++)
        {
            poorerList[person] = new List<int>();
        }

        foreach (int[] people in richer)
        {
            int rich = people[0], poor = people[1];
            poorerList[rich].Add(poor);
            richerCount[poor]++;
        }

        var queue = new Queue<int>();
        for (int person = 0; person != count; person++)
        {
            if (richerCount[person] == 0)
            {
                queue.Enqueue(person);
            }
        }

        var loudest = new int[count];
        for (int person = 0; person != count; person++)
        {
            loudest[person] = person;
        }

        while (queue.Count != 0)
        {
            int rich = queue.Dequeue();

            foreach (int poor in poorerList[rich])
            {
                if (quiet[loudest[poor]] > quiet[loudest[rich]])
                {
                    loudest[poor] = loudest[rich];
                }

                richerCount[poor]--;
                if (richerCount[poor] == 0)
                {
                    queue.Enqueue(poor);
                }
            }
        }

        return loudest;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[3, 2], [2, 1], [1, 0]], [10, 20, 30, 40], [0, 1, 2, 3]);
        Run([[3, 2], [2, 1], [1, 0]], [40, 30, 20, 10], [3, 3, 3, 3]);
    }

    private static void Run(int[][] richer, int[] quiet, int[] expectedResult)
    {
        int[] result = Solution.LoudAndRich(richer, quiet);
        Utilities.PrintSolution((richer, quiet), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
