// Letter Tile Possibilities
// =========================
//
// You are given a string, `tiles`, consisting of uppercase English letters. You can arrange the tiles into sequences of
// any length (from 1 to the length of `tiles`), and each sequence must include at most one tile, `tiles[i]`, from
// `tiles`.
//
// Your task is to return the number of possible non-empty unique sequences you can make using the letters represented
// on `tiles[i]`.
//
// Constraints:
//
// - 1 ≤ `tiles.length` ≤ 7
//
// - The `tiles` string consists of uppercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N11_Subsets.P06_LetterTilePossibilities;

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
