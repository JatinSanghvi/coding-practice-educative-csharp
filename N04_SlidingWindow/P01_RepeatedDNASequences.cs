// Repeated DNA Sequences
// ======================
//
// > A DNA sequence consists of nucleotides represented by the letters 'A', 'C', 'G', and 'T' only. For example,
// > "ACGAATTCCG" is a valid DNA sequence.
//
// Given a string, `s`, that represents a DNA sequence, return all the 10-letter-long sequences (continuous substrings
// of exactly 10 characters) that appear more than once in `s`. You can return the output in any order.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 10^3
// - `s[i]` is either `'A'`, `'C'`, `'G'`, or `'T'`.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P01_RepeatedDNASequences;

public class Solution
{
    public static IList<string> FindRepeatedDnaSequences(string s)
    {
        var sequence = new List<string>();
        var hashCounts = new Dictionary<int, int>();

        int hash = 0;
        for (int pos = 0; pos < s.Length; pos++)
        {
            char nucleotide = s[pos];
            int value = nucleotide switch
            {
                'A' => 0,
                'C' => 1,
                'G' => 2,
                'T' => 3,
                _ => throw new InvalidOperationException(),
            };

            hash = (hash << 2) & 0xFFFFF | value;

            if (pos >= 9)
            {
                hashCounts.TryAdd(hash, 0);
                hashCounts[hash] += 1;

                if (hashCounts[hash] == 2)
                {
                    sequence.Add(s[(pos - 9)..(pos + 1)]);
                }
            }
        }

        return sequence;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("AAAAAAAAAA", new List<string> { });
        Run("AAAAAAAAAAA", new List<string> { "AAAAAAAAAA" });
        Run("ACGTACGTACGTACGTA", new List<string> { "ACGTACGTAC", "CGTACGTACG", "GTACGTACGT", "TACGTACGTA" });
        Run("ACGTACGTACGTAGCTA", new List<string> { });
    }

    private static void Run(string s, IList<string> expectedResult)
    {
        IList<string> result = Solution.FindRepeatedDnaSequences(s);
        Utilities.PrintSolution(s, result);
        CollectionAssert.AreEqual(expectedResult.ToArray(), result.ToArray());
    }
}
