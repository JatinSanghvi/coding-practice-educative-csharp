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
//
// - `digits[i]` is a digit in the range [2,9]

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N11_Subsets.P03_LetterCombinationsOfAPhoneNumber;

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
