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
    // Time complexity: O(w*l+t*l), Space complexity: O(l+t), where l = word-len.
    public int NumWays(string[] words, string target)
    {
        const int Mod = 1_000_000_007;
        int wordLen = words[0].Length;

        // Prepare a table of counts of appearances of each character in a particular position.
        var posCounts = new int[wordLen, 26];
        foreach (string word in words)
        {
            for (int i = 0; i != wordLen; i++)
            {
                posCounts[i, word[i] - 'a']++;
            }
        }

        var ways = new long[target.Length + 1];
        ways[0] = 1; // Number of ways to create empty string.

        // Calculate ways to form strings if only first (i + 1) characters of each word were available.
        for (int i = 0; i != wordLen; i++)
        {
            var newWays = new long[target.Length + 1];
            newWays[0] = 1;

            // Calculate ways to form partial target string with first (j + 1) characters.
            for (int j = 0; j != target.Length; j++)
            {
                // We can construct target substring in two ways:
                // Form substring of length j + 1 with first i characters from each word.
                // Form substring of length j with first i characters and append one of available chars same as target[j].
                newWays[j + 1] = (ways[j + 1] + ways[j] * posCounts[i, target[j] - 'a']) % Mod;
            }

            ways = newWays;
        }

        return (int)ways[target.Length];
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(["aaaa"], "aa", 6);
        Run(["abc", "acb"], "ab", 4);
    }

    private static void Run(string[] words, string target, int expectedResult)
    {
        int result = new Solution().NumWays(words, target);
        Utilities.PrintSolution((words, target), result);
        Assert.AreEqual(expectedResult, result);
    }
}
