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
// - The `tiles` string consists of uppercase English letters.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N11_Subsets.P06_LetterTilePossibilities;

public class Solution
{
    // Time complexity: O(n!), Space complexity: O(n).
    public static int NumTilePossibilities(string tiles)
    {
        var counts = new Dictionary<char, int>();
        foreach (char ch in tiles)
        {
            counts.TryAdd(ch, 0);
            counts[ch]++;
        }

        int possibilities = 0;
        Solve(0);
        return possibilities - 1; // Ignore empty set.

        void Solve(int index)
        {
            possibilities++;
            if (index == tiles.Length) { return; }

            foreach (char ch in counts.Keys)
            {
                if (counts[ch] != 0)
                {
                    counts[ch]--;
                    Solve(index + 1);
                    counts[ch]++;
                }
            }
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("ABC", 15);
        Run("AAB", 8);
        Run("AAA", 3);
    }

    private static void Run(string tiles, int expectedResult)
    {
        int result = Solution.NumTilePossibilities(tiles);
        Utilities.PrintSolution(tiles, result);
        Assert.AreEqual(expectedResult, result);
    }
}
