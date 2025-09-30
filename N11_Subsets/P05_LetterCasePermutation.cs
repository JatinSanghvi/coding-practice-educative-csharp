// Letter Case Permutation
// =======================
//
// Given a string, `s`, consisting of letters and digits, generate all possible variations by modifying each letter
// independently to be either lowercase or uppercase while keeping the digits unchanged. Each letter in the `s` string
// can appear in both cases across different variations, resulting in multiple possible combinations. Return a list
// containing all such variations in any order.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 12
// - `s` consists of lowercase English letters, uppercase English letters, and digits.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N11_Subsets.P05_LetterCasePermutation;

public class Solution
{
    // Time complexity: O(n*2^n), Space complexity: O(n).
    public IList<string> LetterCasePermutation(string s)
    {
        char[] letters = s.ToCharArray();
        var permutations = new List<string>();
        Solve(0);
        return permutations;

        void Solve(int index)
        {
            if (index == letters.Length)
            {
                permutations.Add(new string(letters));
                return;
            }

            char ch = letters[index];
            if (char.IsDigit(ch))
            {
                Solve(index + 1);
            }
            else
            {
                letters[index] = char.ToUpper(ch);
                Solve(index + 1);

                letters[index] = char.ToLower(ch);
                Solve(index + 1);
            }
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("a12b", ["A12B", "A12b", "a12B", "a12b"]);
    }

    private static void Run(string s, string[] expectedResult)
    {
        string[] result = new Solution().LetterCasePermutation(s).ToArray();
        Utilities.PrintSolution(s, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
