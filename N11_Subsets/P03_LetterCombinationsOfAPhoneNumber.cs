// Letter Combinations of a Phone Number
// =====================================
//
// Given a string containing digits from 2 to 9 inclusive, with the possibility of each digit appearing multiple times,
// return all possible letter combinations that the number could represent. Return the answer in any order.
//
// > Note: The number 11 on the telephone dial pad does not correspond to any letter, so the input string only contains
// > digits from 2 to 9.
//
// Constraints:
//
// - 0 ≤ `digits.length` ≤ 4
// - `digits[i]` is a digit in the range [2,9]

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N11_Subsets.P03_LetterCombinationsOfAPhoneNumber;

public class Solution
{
    // Time complexity: O(n*4^n), Space complexity: O(n).
    public static List<string> LetterCombinations(string digits)
    {
        var digitLetters = new Dictionary<char, char[]>
        {
            ['2'] = ['a', 'b', 'c'],
            ['3'] = ['d', 'e', 'f'],
            ['4'] = ['g', 'h', 'i'],
            ['5'] = ['j', 'k', 'l'],
            ['6'] = ['m', 'n', 'o'],
            ['7'] = ['p', 'q', 'r', 's'],
            ['8'] = ['t', 'u', 'v'],
            ['9'] = ['w', 'x', 'y', 'z'],
        };

        var letters = new char[digits.Length];
        var combinations = new List<string>();
        Solve(0);
        return combinations;

        void Solve(int index)
        {
            if (index == digits.Length)
            {
                combinations.Add(new string(letters));
                return;
            }

            foreach (char ch in digitLetters[digits[index]])
            {
                letters[index] = ch;
                Solve(index + 1);
            }
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("", [""]); // Does not agree with evaluation.
        Run("29", ["aw", "ax", "ay", "az", "bw", "bx", "by", "bz", "cw", "cx", "cy", "cz"]);
    }

    private static void Run(string digits, string[] expectedResult)
    {
        string[] result = Solution.LetterCombinations(digits).ToArray();
        Utilities.PrintSolution(digits, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
