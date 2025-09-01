// Number of Spaces Cleaning Robot Cleaned
// =======================================
//
// You are given a 0-indexed 2D binary matrix, `room`, representing a room of size m × n. In this matrix, 0 represents
// an empty space, while 1 represents a space occupied by an object. The top-left corner of the room is always empty in
// all test cases.
//
// A cleaning robot starts at the top-left corner of the room, facing right. It moves straight until it either reaches
// the edge of the room or encounters an object. When this happens, it turns 90 degrees clockwise and continues moving.
// The robot cleans the starting space and every space it visits.
//
// The robot continues moving indefinitely. If it visits a space again while facing the same direction, return the
// number of unique spaces it has cleaned.
//
// Constraints:
//
// - m == `room.length`
// - n == `room[r].length`
// - 1 ≤ m, n ≤ 300
// - `room[r][c]` is either 0 or 1.
// - `room[0][0]` == 0

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N18_Matrices.P13_NumberOfSpacesCleaningRobotCleaned;

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
