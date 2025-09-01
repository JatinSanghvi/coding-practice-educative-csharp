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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N20_Graphs.P02_PathsInMazeThatLeadToSameRoom;

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
