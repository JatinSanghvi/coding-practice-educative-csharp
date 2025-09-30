// Permutations
// ============
//
// Given an input string, return all possible permutations of the string.
//
// > Note: The order of permutations does not matter.
//
// Constraints:
//
// - All characters in `word` are unique.
// - 1 ≤ `word.length` ≤ 6
// - All characters in `word` are lowercase English letters.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N11_Subsets.P02_Permutations;

public class Solution
{
    // Time complexity: O(n*n!), Space complexity: O(n).
    public static IList<string> PermuteWord(string word)
    {
        char[] letters = word.ToCharArray();
        var permutations = new List<string>();
        Solve(0);
        return permutations;

        void Solve(int i)
        {
            if (i == word.Length)
            {
                permutations.Add(new string(letters));
                return;
            }

            for (int j = i; j != letters.Length; j++)
            {
                (letters[i], letters[j]) = (letters[j], letters[i]);
                Solve(i + 1);
                (letters[i], letters[j]) = (letters[j], letters[i]);
            }
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("abc", ["abc", "acb", "bac", "bca", "cba", "cab"]);
    }

    private static void Run(string word, string[] expectedResult)
    {
        string[] result = Solution.PermuteWord(word).ToArray();
        Utilities.PrintSolution(true, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
