// Candy
// =====
//
// You are given an array, `ratings`, where `ratings[i]` represents the rating of the i-th child standing in a line.
// Your task is to distribute candies to each child based on the following rules:
//
// 1. Every child must receive at least one candy.
// 2. Children with a higher rating get more candies than their neighbors.
//
// Determine the minimum total number of candies you must distribute to satisfy the above conditions.
//
// Constraints:
//
// - 1 ≤ `ratings.length` ≤ 1000
// - 0 ≤ `ratings[i]` ≤ 1000

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P13_Candy;

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
