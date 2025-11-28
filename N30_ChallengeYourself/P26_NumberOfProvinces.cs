// Number of Provinces
// ===================
//
// Given n cities, some are directly connected, and others are not. You are given an n×n matrix called `cities`, where
// `cities[i][j]` = 1 means city ith and city jth are directly connected, and `cities[i][j]` = 0 means they are not
// directly connected.
//
// > Note: If city A is directly connected to city B and city B is directly connected to city C, then city A is
// > indirectly connected to city C.
//
// The task is to return the total number of groups of connected cities directly or indirectly. These groups are
// referred to as provinces.
//
// Constraints:
//
// - 1 ≤ n ≤ 200
// - n == `cities.length`
// - n == `cities[i].length`, where 0 ≤ i ≤ n
// - `cities[i][j]` is either 0 or 1.
// - `cities[i][i]` == 1
// - `cities[i][j]` == `cities[j][i]`

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P26_NumberOfProvinces;

public class Solution
{
    // Time complexity: O(n^2), Space complexity: O(n).
    public static int FindConnectedCities(int[][] cities)
    {
        int connections = 0;
        var visited = new bool[cities.Length];

        for (int i = 0; i != cities.Length; i++)
        {
            if (!visited[i])
            {
                connections++;
                Visit(i);
            }
        }

        return connections;

        void Visit(int i)
        {
            visited[i] = true;
            for (int j = 0; j != cities.Length; j++)
            {
                if (!visited[j] && cities[i][j] == 1)
                {
                    Visit(j);
                }
            }
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 0, 1], [0, 1, 0], [1, 0, 1]], 2);
    }

    private static void Run(int[][] cities, int expectedResult)
    {
        int result = Solution.FindConnectedCities(cities);
        Utilities.PrintSolution(cities, result);
        Assert.AreEqual(expectedResult, result);
    }
}
