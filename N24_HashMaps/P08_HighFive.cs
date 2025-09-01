// High Five
// =========
//
// You are given a list of scores for multiple students, represented as `items`, where items[i] = [ID_i, score_i]
// indicates the ID of a student (ID_i) and their score (score_i). Your task is to compute the top five average scores
// for each student.
//
// Return the result as an array of pairs, `result`, where result[j] = [ID_j, topFiveAverage_j] represents the student
// with ID, ID_j, and their corresponding top five average scores. The `result` should be sorted in ascending order by
// ID_j.
//
// > Note: To calculate the top five averages for each student, sum their highest five scores and perform integer
// > division by 5.
//
// Constraints:
//
// - 1 <= `items.length` <= 1000
// - `items[i].length` == 2
// - 1 <= ID_i <= 1000
// - 0 <= score_i <= 100
// - For each ID_i, there will be *at least* five scores.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P08_HighFive;

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
