// Largest Palindromic Number
// ==========================
//
// You are given a string `num` consisting of digits from 0 to 9. Your task is to return the largest possible
// palindromic number as a string by using some or all of the digits in `num`. The resulting palindromic number must not
// have leading zeros.
//
// Note: You may reorder the digits freely, and you must use at least one digit from the `num` string.
//
// Constraints:
//
// - 1 ≤ `num.length` ≤ 1000
// - `num` consists of digits

using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P06_LargestPalindromicNumber;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static string LargestPalindrome(string num)
    {
        var counts = new Dictionary<char, int>();
        for (char digit = '0'; digit <= '9'; digit++)
        {
            counts[digit] = 0;
        }

        foreach (char digit in num)
        {
            counts[digit]++;
        }

        var left = new StringBuilder();
        var right = new StringBuilder();
        var middle = string.Empty;
        for (char digit = '9'; digit >= '0'; digit--)
        {
            while (counts[digit] >= 2 && (digit != '0' || left.Length != 0))
            {
                left.Append(digit);
                right.Insert(0, digit);
                counts[digit] -= 2;
            }

            // Making sure we return the largest number if there are multiple results.
            if (counts[digit] != 0 && middle == string.Empty)
            {
                middle = digit.ToString();
            }
        }

        return $"{left}{middle}{right}";
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("000", "0");
        Run("100", "1");
        Run("110", "101");
        Run("000111222", "2102012");
    }

    private static void Run(string num, string expectedResult)
    {
        string result = Solution.LargestPalindrome(num);
        Utilities.PrintSolution(num, result);
        Assert.AreEqual(expectedResult, result);
    }
}
