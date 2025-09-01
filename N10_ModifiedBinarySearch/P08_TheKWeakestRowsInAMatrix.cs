// The K Weakest Rows in a Matrix
// ==============================
//
// You are given an m × n binary matrix of 1's (representing soldiers) and 0's (representing civilians). The soldiers
// are positioned in front of the civilians, i.e., all the 1's will appear to the left of all the 0's in each row.
//
// A row i is weaker than a row j if any of the following is TRUE:
//
// - The number of soldiers in row i is less than the number of soldiers in row j.
// - Both rows have the same number of soldiers and i < j.
//
// You have to return the indexes of the k weakest rows in the matrix ordered from weakest to strongest.
//
// Constraints:
//
// - m = `matrix.length`
// - n = `matrix[i].length`
// - 2 ≤ n, m ≤ 100
// - 1 ≤ k ≤ m
// - `matrix[i][j]` is either 0 or 1.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P08_TheKWeakestRowsInAMatrix;

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
