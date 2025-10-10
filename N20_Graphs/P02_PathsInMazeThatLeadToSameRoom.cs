// Paths in Maze That Lead to Same Room
// ====================================
//
// A maze consists of n rooms numbered from 1 to n, and some rooms are connected by corridors. You are given a 2D
// integer array, `corridors`, where `corridors[i] = [room_1, room_2]` indicates that there is a corridor connecting
// `room_1` and `room_2`, allowing a person in the maze to go from `room_1` to `room_2` and vice versa.
//
// The designer of the maze wants to know how confusing the maze is. The confusion score of the maze is the number of
// different cycles of length 3.
//
// For example, 1 → 2 → 3 → 1 is a cycle of length 3, but 1 → 2 → 3 → 4 and 1 → 2 → 3 → 2 → 1 are not.
//
// Two cycles are considered to be different if one or more of the rooms visited in the first cycle is not in the second
// cycle.
//
// Return the confusion score of the maze.
//
// Constraints:
//
// - 2 ≤ `n` ≤ 100
// - 1 ≤ `corridors.length` ≤ 5 × 10^2
// - `corridors[i].length` = 2
// - 1 ≤ room_1_i, room_2_i ≤ n
// - room_1_i ≠ room_2_i
// - There are no duplicate corridors.

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N20_Graphs.P02_PathsInMazeThatLeadToSameRoom;

public class Solution
{
    // Time complexity: O(n*c^2), Space complexity: O(n+c).
    public static int NumberOfPaths(int n, int[][] corridors)
    {
        var graph = new Dictionary<int, HashSet<int>>();

        foreach (int[] corridor in corridors)
        {
            int room1 = Math.Min(corridor[0], corridor[1]);
            int room2 = Math.Max(corridor[0], corridor[1]);

            graph.TryAdd(room1, new HashSet<int>());
            graph[room1].Add(room2);
        }

        int paths = 0;
        foreach (HashSet<int> rooms in graph.Values)
        {
            foreach (var room1 in rooms)
            {
                foreach (var room2 in rooms)
                {
                    if (graph.ContainsKey(room1) && graph[room1].Contains(room2))
                    {
                        paths++;
                    }
                }
            }
        }

        return paths;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(4, [[1, 2], [2, 3], [3, 4], [4, 1], [1, 3]], 2);
        Run(4, [[1, 2], [2, 3], [3, 4], [4, 1], [1, 3], [2, 4]], 4);
    }

    private static void Run(int n, int[][] corridors, int expectedResult)
    {
        int result = Solution.NumberOfPaths(n, corridors);
        Utilities.PrintSolution((n, corridors), result);
        Assert.AreEqual(expectedResult, result);
    }
}
