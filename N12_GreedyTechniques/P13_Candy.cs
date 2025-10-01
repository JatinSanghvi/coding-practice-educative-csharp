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

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P13_Candy;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static int Candy(int[] ratings)
    {
        var candies = new int[ratings.Length];

        for (int i = 1; i != ratings.Length; i++)
        {
            if (ratings[i] > ratings[i - 1])
            {
                candies[i] = candies[i - 1] + 1;
            }
        }

        int total = ratings.Length + candies[^1]; // One candy for each child.
        for (int i = ratings.Length - 2; i != -1; i--)
        {
            if (ratings[i] > ratings[i + 1])
            {
                candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
            }
            total += candies[i];
        }

        return total;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3, 4, 5], 15);
        Run([5, 4, 3, 2, 1], 15);
        Run([1, 3, 2, 5, 4], 7);
        Run([1, 1, 1, 1, 1], 5);
    }

    private static void Run(int[] ratings, int expectedResult)
    {
        int result = Solution.Candy(ratings);
        Utilities.PrintSolution(ratings, result);
        Assert.AreEqual(expectedResult, result);
    }
}
