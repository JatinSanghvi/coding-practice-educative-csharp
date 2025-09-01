// Repeated DNA Sequences
// ======================
//
// > A DNA sequence consists of nucleotides represented by the letters 'A', 'C', 'G', and 'T' only. For
// example, "ACGAATTCCG" is a valid DNA sequence.
//
// Given a string, `s`, that represents a DNA sequence, return all the 10-letter-long sequences (continuous
// substrings of exactly 10 characters) that appear more than once in `s`. You can return the output in any
// order.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 10^3
// - `s[i]` is either `'A'`, `'C'`, `'G'`, or `'T'`.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P01_RepeatedDNASequences;

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
