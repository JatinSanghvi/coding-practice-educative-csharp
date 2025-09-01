// Flip Columns For Maximum Number of Equal Rows
// =============================================
//
// Given an m × n binary matrix, `matrix`, return the maximum number of rows where all values become identical after
// flipping any number of columns. Flipping a column means changing every 0 to 1 and every 1 to 0 in that column.
//
// Constraints:
//
// - m == `matrix.length`
// - n == `matrix[i].length`
// - 1 ≤ m, n ≤ 50
// - `matrix[i][j]` is either 0 or 1.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N18_Matrices.P12_FlipColumnsForMaximumNumberOfEqualRows;

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
