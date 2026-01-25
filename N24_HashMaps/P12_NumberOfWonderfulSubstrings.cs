// Number of Wonderful Substrings
// ==============================
//
// A wonderful string is defined as a string in which at most one letter occurs an odd number of times.
//
// For example:
//
// - The string "aabbc" is wonderful because only the letter `'c'` appears an odd number of times.
// - The string "pqpq" is wonderful because all letters appear an even number of times.
// - The string "mn" is not wonderful because both `'m'` and `'n'` appear an odd number of times.
//
// You are given a string `word` that consists of lowercase English letters from `'a'` to `'j'`. Your task is to return
// the total number of wonderful non-empty substrings in `word`.
//
// > Note: If a substring appears multiple times, each occurrence should be counted separately.
//
// Constraints:
//
// - 1 ≤ `word.length` ≤ 10^3
// - `word` consists of lowercase English letters from `'a'` to `'j'`.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P12_NumberOfWonderfulSubstrings;

public class Solution
{
    // Time complexity: O(10n), Space complexity: O(2^10).
    public static long WonderfulSubstrings(string word)
    {
        var stateCounts = new Dictionary<int, int>();
        stateCounts[0] = 1;

        int state = 0;
        long substrings = 0;

        for (int i = 0; i != word.Length; i++)
        {
            int bit = word[i] - 'a';
            state ^= 1 << bit;
            substrings += stateCounts.GetValueOrDefault(state); // Exact state.

            for (bit = 0; bit != 10; bit++)
            {
                substrings += stateCounts.GetValueOrDefault(state ^ (1 << bit)); // One-off states.
            }

            stateCounts[state] = stateCounts.GetValueOrDefault(state) + 1;
        }

        return substrings;
    }

    // Time complexity: O(n^2), Space complexity: O(10).
    public static long WonderfulSubstrings2(string word)
    {
        int len = word.Length;
        long substrings = 0;

        for (int from = 0; from != len; from++)
        {
            var counts = new int[10];
            var odds = 0;
            for (int to = from; to != len; to++)
            {
                int index = word[to] - 'a'; ;
                counts[index]++;
                odds += counts[index] % 2 == 0 ? -1 : 1;

                if (odds <= 1)
                {
                    substrings++;
                }
            }
        }

        return substrings;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("abcabc", 9); // Includes "abcab", "abcabc", "bcabc".
        Run("aabbcc", 18); // Excludes "ab", "abbc", "bc". 
    }

    private static void Run(string word, long expectedResult)
    {
        long result = Solution.WonderfulSubstrings(word);
        Utilities.PrintSolution(word, result);
        Assert.AreEqual(expectedResult, result);
    }
}
