// Given a string, `s`, return `TRUE` if it is a palindrome; otherwise, return `FALSE`.

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
            if (!char.IsLetterOrDigit(s[left]))
            {
                left += 1;
            }
            else if (!char.IsLetterOrDigit(s[right]))
            {
                right -= 1;
            }
            else if (char.ToLower(s[left]) == char.ToLower(s[right]))
            {
                left += 1;
                right -= 1;
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
        Assert.IsTrue(Solution.IsPalindrome(""));
        Assert.IsTrue(Solution.IsPalindrome("()"));
        Assert.IsTrue(Solution.IsPalindrome("A"));
        Assert.IsTrue(Solution.IsPalindrome("A1a"));
        Assert.IsTrue(Solution.IsPalindrome("A11a"));

        Assert.IsFalse(Solution.IsPalindrome("A1B"));
        Assert.IsFalse(Solution.IsPalindrome("A11B"));

        Assert.IsTrue(Solution.IsPalindrome("Madam, in Eden, I'm Adam!"));
    }
}
