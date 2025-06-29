// Next Palindrome Using Same Digits
// =================================
// 
// Given a numeric string, `numStr`, representing a palindrome (composed only of digits). Return the smallest palindrome
// larger than`numStr`that can be created by rearranging its digits. If no such palindrome exists, return an empty
// string`""`.
// 
// Consider the following example to understand the expected output for a given numeric string:
// 
// - input string = `"123321"`
// - The valid palindromes made from the exact digits are `"213312"`, `"231132"`, `"312213"`, `"132231"`, `"321123"`.
// - We return the palindrome `"132231"` because it is the smallest palindrome larger than the input string `"123321"`.
// 
// Constraints:
// 
// - 1 ≤ `numStr.length` ≤ 10^5
// - `numStr` is a palindrome.

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N02_TwoPointers.P09_NextPalindromeUsingSameDigits;

public class Solution
{
    public static string FindNextPalindrome(string numStr)
    {
        char[] numArray = numStr[..(numStr.Length / 2)].ToCharArray();

        int i;
        for (i = numArray.Length - 2; i > -1 && numArray[i] >= numArray[i + 1]; i--) ;

        if (i == -1) { return string.Empty; }

        int j;
        for (j = numArray.Length - 1; numArray[j] <= numArray[i]; j--) ;

        (numArray[i], numArray[j]) = (numArray[j], numArray[i]);

        for (i = i + 1, j = numArray.Length - 1; i < j; i++, j--)
        {
            (numArray[i], numArray[j]) = (numArray[j], numArray[i]);
        }

        string mid = numStr[(numStr.Length / 2)..((numStr.Length + 1) / 2)];
        return new string(numArray) + mid + new string(numArray.Reverse().ToArray());
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("11111", string.Empty);
        Run("02431013420", "03124042130");
        Run("0312442130", "0314224130");
    }

    private static void Run(string numStr, string expectedResult)
    {
        string result = Solution.FindNextPalindrome(numStr);
        Utilities.PrintSolution(numStr, result);
        Assert.AreEqual(expectedResult, result);
    }
}
