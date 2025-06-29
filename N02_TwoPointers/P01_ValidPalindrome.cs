// Valid Palindrome
// ================
// 
// Given a string, `s`, return `TRUE` if it is a palindrome; otherwise, return `FALSE`.
// 
// A phrase is considered a palindrome if it reads the same backward as forward after converting all uppercase letters
// to lowercase and removing any characters that are not letters or numbers. Only alphanumeric characters (letters and
// digits) are taken into account.
// 
// Constraints:
// 
// - 1 ≤ `s.length` ≤ 3000
// - `s` consists only of printable ASCII characters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N02_TwoPointers.P01_ValidPalindrome;

public class Solution
{
    public static bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (!char.IsAsciiLetterOrDigit(s[left]))
            {
                left++;
            }
            else if (!char.IsAsciiLetterOrDigit(s[right]))
            {
                right--;
            }
            else if (char.ToLower(s[left]) == char.ToLower(s[right]))
            {
                left++;
                right--;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("", true);
        Run("A", true);
        Run("A1a", true);
        Run("A1b", false);
        Run("A11a", true);
        Run("A12a", false);
        Run("Madam, in Eden, I'm Adam!", true);
    }

    private static void Run(string s, bool expectedResult)
    {
        bool result = Solution.IsPalindrome(s);
        Utilities.PrintSolution(s, result);
        Assert.AreEqual(expectedResult, result);
    }
}
