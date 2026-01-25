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

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P08_HighFive;

public class Solution
{
    // Time complexity: O(n*logn), Space complexity: O(n).
    public static int[][] HighFive(int[][] items)
    {
        var topScores = new SortedDictionary<int, int[]>();

        foreach (int[] item in items)
        {
            int id = item[0], score = item[1];
            if (!topScores.ContainsKey(id))
            {
                topScores[id] = new int[6];
            }

            int[] topScore = topScores[id];

            int i;
            for (i = 4; i != -1 && topScore[i] < score; i--)
            {
                topScore[i + 1] = topScore[i];
            }

            topScore[i + 1] = score;
        }

        var sumScores = new int[topScores.Count][];

        int j = 0;
        foreach ((int id, int[] scores) in topScores)
        {
            sumScores[j++] = [id, scores[..5].Sum() / 5];
        }

        return sumScores;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 5], [2, 25], [1, 10], [2, 20], [1, 15], [2, 15], [1, 20], [2, 10], [1, 25], [2, 5], [1, 30]], [[1, 20], [2, 15]]);
    }

    private static void Run(int[][] items, int[][] expectedResult)
    {
        int[][] result = Solution.HighFive(items);
        Utilities.PrintSolution(items, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
