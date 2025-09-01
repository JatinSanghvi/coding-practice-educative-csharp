// Number of Ways to Form Target String Given a Dictionary
// =======================================================
//
// You are given a list of n strings, `words`, where each string has the same length m, and a target string, `target`,
// of length t. A `target` can be formed using the given `words` under the following rules:
//
// - You must build the `target` from left to right.
// - To form the `i`th character (0-indexed) of `target`, you can choose any `k`th character of any `j`th string in
//   `words`, i.e., `target[i] = words[j][k]`.
// - Once you use the `k`th character of the `j`th string in `words`, your next letter can't be a character from index 0
//   through `k` of any string in `words`. In simple words, all characters to the left of or at index `k` become
//   unusable for every string, and the next letter must come from positions strictly to the right of `k`.
// - Repeat the process until you've formed the complete `target`.
//
// > Note: You can use multiple characters from the same string in `words`, as long as the rules above are followed.
//
// Your task is to find and return the number of ways to form the string `target` from `words`. As the answer might be
// too large, return it modulo 10^9 + 7.
//
// Constraints:
//
// - 1 ≤ `words.length` ≤ 1000
// - 1 ≤ `words[i].length` ≤ 1000
// - All strings in `words` have the same length.
// - 1 ≤ `target.length` ≤ 1000
// - `words[i]` and `target` contain only lowercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P17_NumberOfWaysToFormTargetStringGivenADictionary;

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
